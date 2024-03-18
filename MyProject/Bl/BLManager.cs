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
    public IBlLessons Lessons { get; set; }
    public BLManager()
    {
        ServiceCollection services = new ServiceCollection();

        services.AddSingleton<Dal.DalManager>();
        services.AddScoped<IBlTrainers, BlTrainersServices>();
        services.AddScoped<IBlExcersizers, BlExcersizersServices>();
        services.AddScoped<IBlLessons, BlLessonsServices>();

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        this.Trainers = serviceProvider.GetRequiredService<IBlTrainers>();
        this.Excersizers = serviceProvider.GetRequiredService<IBlExcersizers>();
        this.Lessons = serviceProvider.GetRequiredService<IBlLessons>();
    }
}