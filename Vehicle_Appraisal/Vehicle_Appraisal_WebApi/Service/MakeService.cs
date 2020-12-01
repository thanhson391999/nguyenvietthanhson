using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.Infrastructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.DALs
{
    public class MakeService : IMakeService
    {
        private readonly DbContextDTO _dbContextDTO;
        private DbSet<MakeDTO> dbset;
        private IMapper _mapper;
        public MakeService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _dbContextDTO = dbContextDTO;
            _mapper = mapper;
            dbset = dbContextDTO.Set<MakeDTO>();
        }

        public async Task<ApiResultVM<string>> Delete(int id)
        {
            var makeVM = await GetById(id);
            if (makeVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Make doesn't exist");
            }
            var checkConstraint = _dbContextDTO.Set<VehicleDTO>().Where(x => x.MakeId.Equals(id)).Where(x => x.isBought == false).AsNoTracking().FirstOrDefault();
            if (checkConstraint != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Can't delete because make is existing in vehicle");
            }
            var makeDTO = _mapper.Map<MakeDTO>(makeVM);
            makeDTO.isDelete = true;
            makeDTO.UpdateAt = DateTime.Now;
            dbset.Update(makeDTO);
            //await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Delete Success");
        }

        public async Task<List<MakeVM>> GetAll()
        {
            var listMakeDTO = await dbset.Where(x => x.isDelete == false).ToListAsync();
            var listMakeVM = _mapper.Map<List<MakeVM>>(listMakeDTO);
            return listMakeVM;
        }

        public async Task<List<MakeVM>> GetAllNotDelete()
        {
            var listMakeDTO = await dbset.ToListAsync();
            var listMakeVM = _mapper.Map<List<MakeVM>>(listMakeDTO);
            return listMakeVM;
        }

        public async Task<MakeVM> GetById(int id)
        {
            var makeDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefaultAsync();
            var makeVM = _mapper.Map<MakeVM>(makeDTO);
            return makeVM;
        }

        public async Task<ApiResultVM<string>> Insert(MakeVM makeVM)
        {
            var checkMake = await dbset.Where(x => x.Name.Equals(makeVM.Name)).Where(x => x.isDelete == false).AsNoTracking().FirstOrDefaultAsync();
            if (checkMake != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Make's name already exist");
            }
            var makeDTO = _mapper.Map<MakeDTO>(makeVM);
            makeDTO.CreateAt = DateTime.Now;
            makeDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(makeDTO);
            //await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Insert Success");
        }

        public async Task<ApiResultVM<string>> Update(MakeVM makeVM, int id)
        {
            var checkValue = await GetById(id);
            if (checkValue == null) 
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Make doesn't exist");
            }
            var checkMake = await dbset.Where(x=>x.Id != id).Where(x => x.Name.Equals(makeVM.Name)).Where(x => x.isDelete == false).AsNoTracking().FirstOrDefaultAsync();
            if (checkMake != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Make's name already exist");
            }
            var makeDTO = _mapper.Map<MakeDTO>(makeVM);
            makeDTO.Id = id;
            makeDTO.UpdateAt = DateTime.Now;
            dbset.Update(makeDTO);
            //await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Update Success");
        }
    }
}
