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
    public ITrainers Trainers { get; }
    public IExcersizers Excersizers { get; }
    public ILessons Lessons { get; set; }
    public BLManager()
    {
        ServiceCollection services = new ServiceCollection();

        services.AddSingleton<Dal.DalManager>();
        services.AddScoped<ITrainers, TrainersServices>();
        services.AddScoped<IExcersizers, ExcersizersServices>();
        services.AddScoped<ILessons, LessonsServices>();

        ServiceProvider serviceProvider = services.BuildServiceProvider();

        Trainers = serviceProvider.GetRequiredService<ITrainers>();
        Excersizers = serviceProvider.GetRequiredService<IExcersizers>();
        Lessons = serviceProvider.GetRequiredService<ILessons>();
    }
}