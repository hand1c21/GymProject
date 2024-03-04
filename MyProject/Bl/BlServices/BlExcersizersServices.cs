using Bl.BlApi;
using Bl.BlModels;
//using Bl.BlModels;
//using Dal.Models;
using Dal;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices;

internal class BlExcersizersServices : IBlExcersizers
{
    Dal.DalApi.IExcersizers blExcersizers;
    public BlExcersizersServices(DalManager instance)
    {
        this.blExcersizers = instance.Excersizers;
    }

    public List<Bl.BlModels.BlExcersizer> GetAll()
    {
        List<Dal.Models.Excersizer> excersizers = blExcersizers.GetAll();
        List<Bl.BlModels.BlExcersizer> excersizers1 = new List<BlModels.BlExcersizer>();
        for (int i = 0; i < excersizers.Count; i++)
        {
            excersizers1.Add(new BlExcersizer(excersizers[i].Id, excersizers[i].FirstName, excersizers[i].LastName, excersizers[i].MobileNumber, excersizers[i].TrainerCode, excersizers[i].InsuranceCode, excersizers[i].Lessons));
        }
        ////IEnumerable<Excersizer> ex = excersizers1;

        return excersizers1;
    }

    public BlExcersizer Get(int id)
    {
        Excersizer ex = blExcersizers.Get(id);
        if(ex != null) 
        { 
            BlExcersizer excersizer = new BlExcersizer(ex.Id , ex.FirstName, ex.LastName, ex.MobileNumber, ex.TrainerCode, ex.InsuranceCode, ex.Lessons);
            return excersizer;
        }
        return null;
    }

    public BlExcersizer Add(BlExcersizer entity)
    {
        Excersizer excersizer = new Excersizer();
        excersizer.Id = entity.Id;
        excersizer.FirstName = entity.FirstName;
        excersizer.LastName = entity.LastName;
        excersizer.MobileNumber = entity.MobileNumber;
        excersizer.TrainerCode = entity.TrainerCode;

        blExcersizers.Add(excersizer);
        return entity;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public BlExcersizer Update(BlExcersizer entity)
    {
        throw new NotImplementedException();
    }
}