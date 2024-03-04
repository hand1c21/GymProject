using Bl.BlApi;
using Dal;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    internal class BlLessonsServices : IBlLessons
    {
        Dal.DalApi.ILessons lesson;
        public BlLessonsServices(DalManager instance)
        {
            this.lesson = instance.Lessons;
        }

        public List<Lesson> GetAll()
        {
            throw new NotImplementedException();
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
