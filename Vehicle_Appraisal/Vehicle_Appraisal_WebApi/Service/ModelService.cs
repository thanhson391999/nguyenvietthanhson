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
    public class ModelService : IModelService
    {
        private readonly DbContextDTO _dbContextDTO;
        private IMapper _mapper;
        private DbSet<ModelDTO> dbset;
        public ModelService(DbContextDTO dbContextDTO, IMapper mapper)
        {
            _mapper = mapper;
            _dbContextDTO = dbContextDTO;
            dbset = dbContextDTO.Set<ModelDTO>();
        }
        public async Task<ApiResultVM<string>> Delete(int id)
        {
            var modelVM = await GetById(id);
            if (modelVM == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Model doesn't exist");
            }
            var checkConstraint = _dbContextDTO.Set<VehicleDTO>().Where(x => x.ModelId.Equals(id)).Where(x => x.isBought == false).AsNoTracking().FirstOrDefault();
            if (checkConstraint != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Can't delete because model is existing in vehicle");
            }
            var modelDTO = _mapper.Map<ModelDTO>(modelVM);
            modelDTO.isDelete = true;
            modelDTO.UpdateAt = DateTime.Now;
            dbset.Update(modelDTO);
            //await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Delete Success");
        }

        public async Task<List<ModelVM>> GetAll()
        {
            var listmodelDTO = await dbset.Where(x => x.isDelete == false).ToListAsync();
            var listmodelVM = _mapper.Map<List<ModelVM>>(listmodelDTO);
            return listmodelVM;
        }

        public async Task<List<ModelVM>> GetAllNotDelete()
        {
            var listmodelDTO = await dbset.ToListAsync();
            var listmodelVM = _mapper.Map<List<ModelVM>>(listmodelDTO);
            return listmodelVM;
        }

        public async Task<ModelVM> GetById(int id)
        {
            var modelDTO = await dbset.Where(x => x.Id.Equals(id)).Where(x => x.isDelete == false).AsNoTracking().SingleOrDefaultAsync();
            var modelVM = _mapper.Map<ModelVM>(modelDTO);
            return modelVM;
        }

        public async Task<ApiResultVM<string>> Insert(ModelVM modelVM)
        {
            var checkModel = await dbset.Where(x => x.Name.Equals(modelVM.Name)).AsNoTracking().FirstOrDefaultAsync();
            if (checkModel != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Model already exist");
            }
            var modelDTO = _mapper.Map<ModelDTO>(modelVM);
            modelDTO.CreateAt = DateTime.Now;
            modelDTO.UpdateAt = DateTime.Now;
            await dbset.AddAsync(modelDTO);
            //await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Insert Success");
        }

        public async Task<ApiResultVM<string>> Update(ModelVM modelVM, int id)
        {
            var checkValue = await GetById(id);
            if (checkValue == null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Model doesn't exist");
            }
            var checkModel = await dbset.Where(x=>x.Id != id).Where(x => x.Name.Equals(modelVM.Name)).AsNoTracking().FirstOrDefaultAsync();
            if (checkModel != null)
            {
                _dbContextDTO.Dispose();
                return new ApiErrorResultVM<string>("Model's name already exist");
            }
            var modelDTO = _mapper.Map<ModelDTO>(modelVM);
            modelDTO.Id = id;
            modelDTO.UpdateAt = DateTime.Now;
            dbset.Update(modelDTO);
            //await _dbContextDTO.SaveChangesAsync();
            return new ApiSuccessResultVM<string>("Update Success");
        }
    }
}
