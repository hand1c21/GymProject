using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    internal class ExcersizersServices : IExcersizers
    {
        GymContext Context { get; set; }
        public ExcersizersServices(GymContext gymContext)
        {
            Context = gymContext;
        }
        
        public List<Excersizer> GetAll()
        {
            List<Excersizer> result = Context.Excersizers.Include(l => l.Lessons).ToList();
            return result;
        }
        
        public Excersizer Get(int id)
        {
            Excersizer excersizer = Context.Excersizers.FirstOrDefault(e => e.Id.Equals(id));
            return excersizer;
        }

        public Excersizer Add(Excersizer entity)
        {
            Context.Excersizers.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Excersizer Update(Excersizer entity)
        {
            throw new NotImplementedException();
        }
    }
}
