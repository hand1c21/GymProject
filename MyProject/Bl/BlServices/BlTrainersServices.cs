using AutoMapper;
using Bl.BlApi;
using Bl.BlDalModels;
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
    internal class BlTrainersServices : IBlTrainers
    {
        Dal.DalApi.ITrainers blTrainers;
        IMapper map;
        public BlTrainersServices(DalManager instance, IMapper mapper)
        {
            this.blTrainers = instance.Trainers;
            this.map = mapper;
        }

        public List<BlTrainer> GetAll()
        {
            List<Trainer> trainers = blTrainers.GetAll();
            List<BlTrainer> trainers1 = new List<BlTrainer>();
            for (int i = 0; i < trainers.Count; i++)
            {
                trainers1.Add(map.Map<BlTrainer>(trainers[i]));
            }
            //IEnumerable<Excersizer> ex = excersizers1;

            return trainers1;
        }

        public BlTrainer Get(int id)
        {
            Trainer bltr = blTrainers.Get(id);
            if (bltr != null)
            {
                BlTrainer trainer = map.Map<BlTrainer>(bltr);
                    //new (bltr.Code,bltr.FirstName,bltr.LastName, bltr.MobileNumber, bltr.TypeOfTrainingCode, bltr.EmailAddress, bltr.Lessons);
                return trainer;
            }
            return null;
        }

        public BlTrainer Add(BlTrainer entity)
        {
            Trainer trainer = new Trainer();
            trainer.Code = entity.Code;
            trainer.FirstName = entity.FirstName;
            trainer.LastName = entity.LastName;
            trainer.MobileNumber = entity.MobileNumber;
            trainer.TypeOfTrainingCode = entity.TypeOfTrainingCode;
            trainer.EmailAddress = entity.EmailAddress;

            blTrainers.Add(trainer);
            return entity;
        }

        public void Delete(int id)
        {
            blTrainers.Delete(id);
        }


        public BlTrainer Update(BlTrainer entity)
        {
            throw new NotImplementedException();
        }
    }
}
