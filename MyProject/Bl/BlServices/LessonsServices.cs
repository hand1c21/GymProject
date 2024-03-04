using Bl.BlApi;
using Dal;
using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    internal class LessonsServices : ILessons
    {
        Dal.DalApi.ILessons lesson;
        public LessonsServices(DalManager instance)
        {
            this.lesson = instance.Lessons;
        }


        public List<Lesson> GetAll()
        {
            //List<Dal.Models.Lesson> lessons =lesson.GetAll();
            //List < Bl.BlModels.Lesson> lessons1 = new List<BlModels.Lesson>();
            //for (int i = 0; i < lessons.Count; i++)
            //{
            //    lessons1.Add(new Lesson(lessons.Tra, excersizers[i].FirstName, excersizers[i].LastName, excersizers[i].MobileNumber, excersizers[i].TrainerCode, excersizers[i].InsuranceCode/*, excersizers[i].Lessons*/));
            //}
            ////IEnumerable<Excersizer> ex = excersizers1;

            //return lessons1;
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
