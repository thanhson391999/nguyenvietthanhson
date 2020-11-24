using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly DbContextDTO _dbContextDTO;
        private DbSet<CustomerDTO> dbset;
        private IMapper _mapper;
        public CustomerService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<CustomerDTO>();
        }
        public async Task<bool> Delete(int id)
        {
            var customerVM = await GetById(id);
            if (customerVM == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var checkConstraint = _dbContextDTO.Set<VehicleDTO>().Where(x => x.CustomerId.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().FirstOrDefault();
            if (checkConstraint != null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            var customerDTO = _mapper.Map<CustomerDTO>(customerVM);
            customerDTO.isDelete = true;
            customerDTO.UpdateAt = DateTime.Now;
            dbset.Update(customerDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<List<CustomerVM>> GetAll()
        {
            var listcustomerDTO = await dbset.Where(x => x.isDelete == false).ToListAsync();
            var listcustomerVM = _mapper.Map<List<CustomerVM>>(listcustomerDTO);
            return listcustomerVM;
        }

        public async Task<List<CustomerVM>> GetAllNotDelete()
        {
            var listcustomerDTO = await dbset.ToListAsync();
            var listcustomerVM = _mapper.Map<List<CustomerVM>>(listcustomerDTO);
            return listcustomerVM;
        }

        public async Task<CustomerVM> GetById(int id)
        {
            var customerDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefaultAsync();
            var customerVM = _mapper.Map<CustomerVM>(customerDTO);
            return customerVM;
        }
        public async Task<bool> Insert(CustomerVM customerVM)
        {
            var checkCustomer = dbset.Where(x => (x.FirstName + " " + x.LastName).Equals(customerVM.FirstName + " " + customerVM.LastName)).AsNoTracking().FirstOrDefault();
            if (customerVM.FirstName == null ||
                customerVM.LastName == null ||
                customerVM.Phone == null ||
                customerVM.Email == null ||
                customerVM.Address1 == null ||
                customerVM.City == null ||
                customerVM.Country == null ||
                checkCustomer != null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            if (customerVM.Address2 == null)
            {
                customerVM.Address2 = "Không";
            }
            var customerDTO = _mapper.Map<CustomerDTO>(customerVM);
            customerDTO.CreateAt = DateTime.Now;
            customerDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(customerDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }

        public async Task<List<CustomerVM>> Search(string name, string phone, string email, string address, string city, string country)
        {
            if (name != null)
            {
                var customerDTO = await dbset.Where(x => (x.FirstName + " " + x.LastName).Contains(name)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                var customerVM = _mapper.Map<List<CustomerVM>>(customerDTO);
                return customerVM;
            }
            if (phone != null)
            {
                var customerDTO = await dbset.Where(x => (x.Phone).Contains(phone)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                var customerVM = _mapper.Map<List<CustomerVM>>(customerDTO);
                return customerVM;
            }
            if (email != null)
            {
                var customerDTO = await dbset.Where(x => (x.Email).Contains(email)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                var customerVM = _mapper.Map<List<CustomerVM>>(customerDTO);
                return customerVM;
            }
            if (address != null)
            {
                var customerDTO = await dbset.Where(x => (x.Address1.Contains(address)||x.Address2.Contains(address))).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                var customerVM = _mapper.Map<List<CustomerVM>>(customerDTO);
                return customerVM;
            }
            if (city != null)
            {
                var customerDTO = await dbset.Where(x => (x.City).Contains(city)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                var customerVM = _mapper.Map<List<CustomerVM>>(customerDTO);
                return customerVM;
            }
            else
            {
                var customerDTO = await dbset.Where(x => (x.Country).Contains(country)).Where(x => x.isDelete == false).AsNoTracking().ToListAsync();
                var customerVM = _mapper.Map<List<CustomerVM>>(customerDTO);
                return customerVM;
            }
        }

        public async Task<bool> Update(CustomerVM customerVM, int id)
        {
            var checkValue = await GetById(id);
            if (checkValue == null ||
                customerVM.FirstName == null ||
                customerVM.LastName == null ||
                customerVM.Phone == null ||
                customerVM.Email == null ||
                customerVM.Address1 == null ||
                customerVM.City == null ||
                customerVM.Country == null)
            {
                _dbContextDTO.Dispose();
                return false;
            }
            if (customerVM.Address2 == null)
            {
                customerVM.Address2 = "Không";
            }
            var customerDTO = _mapper.Map<CustomerDTO>(customerVM);
            customerDTO.Id = id;
            customerDTO.UpdateAt = DateTime.Now;
            dbset.Update(customerDTO);
            await _dbContextDTO.SaveChangesAsync();
            return true;
        }
    }
}
