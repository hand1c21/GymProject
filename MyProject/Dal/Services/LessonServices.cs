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
        public Lesson Get(int id)
        {
            Lesson lesson = Context.Lessons.FirstOrDefault(e => e.Id.Equals(id));
            return lesson;
        }

        public Lesson Add(Lesson entity)
        {
            if (Context.Lessons.Find(entity.Id) == null)
            {
                Context.Lessons.Add(entity);
                Context.SaveChanges();
                return entity;
            }
            return null;
        }


        public void Delete(int id)
        {
            Lesson lesson = Get(id);
            if (lesson != null)
            {
                Context.Lessons.Remove(lesson);
                Context.SaveChanges();
                Console.WriteLine("succses delete");
            }
            else Console.WriteLine("couldn't find");
            //return excersizer;
        }



        public Lesson Update(Lesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
