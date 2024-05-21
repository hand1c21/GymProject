using Bl.BlApi;
using Bl.BlModels;
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
    internal class BlLessonsServices : IBlLessons
    {
        Dal.DalApi.ILessons blLessons;
        public BlLessonsServices(DalManager instance)
        {
            this.blLessons = instance.Lessons;
        }


        public List<BlLesson> GetAll()
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

        public BlLesson Get(int id)
        {
            //Excersizer ex = blExcersizers.Get(id);
            //if (ex != null)
            //{
            //    BlExcersizer excersizer = new BlExcersizer(ex.Id, ex.FirstName, ex.LastName, ex.MobileNumber, ex.TrainerCode, ex.InsuranceCode, ex.Lessons);
            //    return excersizer;
            //}
            return null;
        }

        public BlLesson Add(BlLesson entity)
        {
            //Excersizer excersizer = new Excersizer();
            //excersizer.Id = entity.Id;
            //excersizer.FirstName = entity.FirstName;
            //excersizer.LastName = entity.LastName;
            //excersizer.MobileNumber = entity.MobileNumber;
            //excersizer.TrainerCode = entity.TrainerCode;
            //excersizer.InsuranceCode = entity.InsuranceCode;

            //blExcersizers.Add(excersizer);
            return entity;
        }

        public void Delete(int id)
        {
            blLessons.Delete(id);
        }

        public BlLesson Update(BlLesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
