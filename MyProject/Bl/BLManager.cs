using AutoMapper;
//using Bl.AutoMapper;
using Bl.BlApi;
using Bl.BlModels;
using Bl.BlServices;
//using Dal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl;

public class BLManager
{
    public IBlTrainers Trainers { get; }
    public IBlExcersizers Excersizers { get; }
    public IBlAppointment Appointments { get; set; }
    public BLManager()
    {
        ServiceCollection services = new ServiceCollection();
        
        
        services.AddSingleton<Dal.DalManager>();
        services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));
        services.AddScoped<IBlTrainers, BlTrainersServices>();
        services.AddScoped<IBlExcersizers, BlExcersizersServices>();
        services.AddScoped<IBlAppointment, BlAppointmentsServices>();

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        this.Excersizers = serviceProvider.GetRequiredService<IBlExcersizers>();
        this.Trainers = serviceProvider.GetRequiredService<IBlTrainers>();
        
        this.Appointments = serviceProvider.GetRequiredService<IBlAppointment>();
    }
}