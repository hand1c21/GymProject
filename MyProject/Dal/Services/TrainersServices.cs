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
        public Trainer Get(int id)
        {
            Trainer trainer = Context.Trainers.FirstOrDefault(e => e.Id.Equals(id));
            return trainer;
        }

        public Trainer Add(Trainer entity)
        {
            if (Context.Trainers.Find(entity.Id) == null)
            {
                Context.Trainers.Add(entity);
                Context.SaveChanges();
                return entity;
            }
            return null;
        }


        public void Delete(int id)
        {
            Trainer trainer = Get(id);
            if (trainer != null)
            {
                Context.Trainers.Remove(trainer);
                Context.SaveChanges();
                Console.WriteLine("succses delete");
            }
            else Console.WriteLine("couldn't find");
            //return excersizer;
        }


        public Trainer Update(Trainer entity)
        {
            throw new NotImplementedException();
        }
    }
}
