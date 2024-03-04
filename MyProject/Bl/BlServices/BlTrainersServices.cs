using Bl.BlApi;
using Bl.BlModels;
using Dal;
using Dal.DalApi;
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
        public BlTrainersServices(DalManager instance)
        {
            this.blTrainers = instance.Trainers;
        }

        public List<Bl.BlModels.BlTrainer> GetAll()
        {
            List<Dal.Models.Trainer> trainers = blTrainers.GetAll();
            List<Bl.BlModels.BlTrainer> trainers1 = new List<BlModels.BlTrainer>();
            for (int i = 0; i < trainers.Count; i++)
            {
                trainers1.Add(new BlTrainer(trainers[i].Code, trainers[i].FirstName, trainers[i].LastName, trainers[i].MobileNumber, trainers[i].TypeOfTrainingCode, trainers[i].EmailAddress, trainers[i].Lessons));
            }
            //IEnumerable<Excersizer> ex = excersizers1;

            return trainers1;
        }

        public BlTrainer Add(BlTrainer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BlTrainer Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public BlTrainer Update(BlTrainer entity)
        {
            throw new NotImplementedException();
        }
    }
}
