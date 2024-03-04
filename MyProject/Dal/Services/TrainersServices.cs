using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    internal class TrainersServices : ITrainers
    {
        GymContext Context { get; set; }
        public TrainersServices(GymContext gymContext)
        {
            Context = gymContext;
        }
        public List<Trainer> GetAll()
        {
            List<Trainer> result = Context.Trainers.ToList();
            return result;
        }
        public Trainer Add(Trainer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Trainer Get(int id)
        {
            throw new NotImplementedException();
        }

       

        public Trainer Update(Trainer entity)
        {
            throw new NotImplementedException();
        }
    }
}
