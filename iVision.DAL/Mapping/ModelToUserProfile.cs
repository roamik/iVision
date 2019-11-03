using AutoMapper;
using iVision.MODELS.Entities;
using iVision.MODELS.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace iVision.DAL.Mapping
{
    public class ModelToUserProfile : Profile
    {
        public ModelToUserProfile()
        {
            CreateMap<User, UserResource>();
        }
    }
}
