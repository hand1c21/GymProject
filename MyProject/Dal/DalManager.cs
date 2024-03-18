using Dal.DalApi;
using Dal.Services;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalManager
    {
        public ITrainers Trainers { get; set; }
        public IExcersizers Excersizers { get; set; }
        public ILessons Lessons { get; set; }

        public DalManager()
        {
            ServiceCollection service = new ServiceCollection();

            service.AddSingleton<GymContext>();

            service.AddScoped<IExcersizers, ExcersizersServices>();
            service.AddScoped<ITrainers, TrainersServices>();
            service.AddScoped<ILessons, LessonServices>();

            ServiceProvider serviceProvider = service.BuildServiceProvider();

            this.Trainers =  serviceProvider.GetRequiredService<ITrainers>();
            this.Excersizers = serviceProvider.GetRequiredService<IExcersizers>();
            this.Lessons = serviceProvider.GetRequiredService<ILessons>();
        }
    }
}
