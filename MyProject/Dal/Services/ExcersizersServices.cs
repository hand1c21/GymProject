using Dal.DalApi;
using Dal.Models;
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
            List<Excersizer> result = Context.Excersizers.ToList();
            return result;
        }
        
        public Excersizer Get(int id)
        {

            throw new NotImplementedException();
        }

        public Excersizer Add(Excersizer entity)
        {
            throw new NotImplementedException();
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
