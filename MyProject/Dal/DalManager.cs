using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal class DalManager
    {
        public ITrainers Trainers { get; set; }
        public IExcersizers Excersizers { get; set; }

        public DalManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ITrainers, Trainer>();
            services.AddScoped<IExcersizers, Excersizer>();

        }
    }
}
