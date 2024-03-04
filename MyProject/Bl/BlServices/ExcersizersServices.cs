using Bl.BlApi;
using Bl.BlModels;
//using Bl.BlModels;
using Dal;
//using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices;

internal class ExcersizersServices : IBlExcersizers
{
    Dal.DalApi.IExcersizers blExcersizers;
    public ExcersizersServices(DalManager instance)
    {
        this.blExcersizers = instance.Excersizers;
    }

    //public List<Bl.BlModels.Excersizer> GetAll()
    //{
    //    List<Dal.Models.Excersizer> excersizers = blExcersizers.GetAll();
    //    List<Bl.BlModels.Excersizer> excersizers1 = new List<BlModels.Excersizer>();
    //    for (int i = 0; i < excersizers.Count; i++)
    //    {
    //        excersizers1.Add(new BlModels.Excersizer { FirstName = excersizers[i].FirstName, Id = excersizers[i].Id, LastName = excersizers[i].LastName, Lessons = (ICollection<BlModels.Lesson>)excersizers[i].Lessons, MobileNumber = excersizers[i].MobileNumber, TrainerCode = excersizers[i].TrainerCode });
    //    }
    //    //var list = blExcersizers.GetAll();
    //    //list.ForEach(e => excersizers.Add(new Excersizer() { Id = e.Id, FirstName = e.FirstName, LastName = e.LastName,
    //    //    MobileNumber = e.MobileNumber, TrainerCode = e.TrainerCode}));
    //    return excersizers1;
    //}

    public List<Bl.BlModels.BlExcersizer> GetAll()
    {
        //IEnumerable<Excersizer> patients = 
        //    blExcersizers..Include(patient => patient.Address).ThenInclude(address => address.Street).ThenInclude(street => street.City);
        List<Dal.Models.Excersizer> excersizers = blExcersizers.GetAll();
        List<Bl.BlModels.BlExcersizer> excersizers1 = new List<BlModels.BlExcersizer>();
        for (int i = 0; i < excersizers.Count; i++)
        {
            excersizers1.Add(new BlExcersizer(excersizers[i].Id, excersizers[i].FirstName, excersizers[i].LastName, excersizers[i].MobileNumber, excersizers[i].TrainerCode, excersizers[i].InsuranceCode/*, excersizers[i].Lessons*/));
        }
        //IEnumerable<Excersizer> ex = excersizers1;
        
        return excersizers1;
    }

    public BlExcersizer Get(int id)
    {
        throw new NotImplementedException();
    }

    public BlExcersizer Add(BlExcersizer entity)
    {
        throw new NotImplementedException();
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
