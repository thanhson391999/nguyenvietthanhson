﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.DTOs;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.AutoMapper
{
    public class AutoMapperConfigure : Profile
    {
        public AutoMapperConfigure()
        {
            CreateMap<MakeDTO, MakeVM>();
            CreateMap<MakeVM, MakeDTO>();
            CreateMap<ModelDTO, ModelVM>();
            CreateMap<ModelVM, ModelDTO>();
            CreateMap<CustomerDTO, CustomerVM>();
            CreateMap<CustomerVM, CustomerDTO>();
            CreateMap<VehicleDTO, VehicleVM>();
            CreateMap<VehicleVM, VehicleDTO>();
            CreateMap<ConditionDTO, ConditionVM>();
            CreateMap<ConditionVM, ConditionDTO>();
            CreateMap<VehicleAppraisalDTO, VehicleAppraisalVM>();
            CreateMap<VehicleAppraisalVM, VehicleAppraisalDTO>();
            CreateMap<AppUserDTO, AppUserVM>();
            CreateMap<AppUserVM, AppUserDTO>();
            CreateMap<AppUserRoleDTO, AppUserRoleVM>();
            CreateMap<AppUserRoleVM, AppUserRoleDTO>();
            CreateMap<VehicleCrawlDataDTO, VehicleCrawlDataVM>();
            CreateMap<VehicleCrawlDataVM, VehicleCrawlDataDTO>();
        }
    }
}
