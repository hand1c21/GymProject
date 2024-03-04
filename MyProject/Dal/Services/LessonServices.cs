using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    internal class LessonServices : ILessons
    {
        GymContext Context { get; set; }
        public LessonServices(GymContext gymContext)
        {
            Context = gymContext;
        }
        public List<Lesson> GetAll()
        {
            List<Lesson> result = Context.Lessons.ToList();
            return result;
        }
        public Lesson Add(Lesson entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Lesson Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public Lesson Update(Lesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
