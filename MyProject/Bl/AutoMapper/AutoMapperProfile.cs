using AutoMapper;
using Bl.BlDalModels;
using Bl.BlModels;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.AutoMapper
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Excersizer, BlDalExcersizer>().ReverseMap();
            CreateMap<Trainer, BlDalTrainer>().ReverseMap();
            CreateMap<Appointment, BlDalAppointment>().ReverseMap();
        }
    }
}
