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
    internal class TrainersServices : ITrainers
    {
        Dal.DalApi.ITrainers blTrainers;
        public TrainersServices(DalManager instance)
        {
            this.blTrainers = instance.Trainers;
        }

        public List<Bl.BlModels.Trainer> GetAll()
        {
            List<Dal.Models.Trainer> trainers = blTrainers.GetAll();
            List<Bl.BlModels.Trainer> trainers1 = new List<BlModels.Trainer>();
            for (int i = 0; i < trainers.Count; i++)
            {
                trainers1.Add(new Trainer(trainers[i].Code, trainers[i].FirstName, trainers[i].LastName, trainers[i].MobileNumber, trainers[i].TypeOfTrainingCode, trainers[i].EmailAddress/*, excersizers[i].Lessons*/));
            }
            //IEnumerable<Excersizer> ex = excersizers1;

            return trainers1;
        }

        public Trainer Add(Trainer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Trainer Get(int id)
        {
            throw new NotImplementedException();
        }

        

        public Trainer Update(Trainer entity)
        {
            throw new NotImplementedException();
        }
    }
}
