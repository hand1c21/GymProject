using Bl.BlApi;
using Bl.BlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices;

internal class ExcersizersServices : IExcersizers
{
    Dal.DalApi.IExcersizers blExcersizers;
    public ExcersizersServices(BLManager instance)
    {
        blExcersizers = (Dal.DalApi.IExcersizers)instance.Excersizers;
    }

    public List<Excersizer> GetAll()
    {
        List<BlModels.Excersizer> excersizers = new List<Excersizer>();
        var list = blExcersizers.GetAll();
        list.ForEach(e => excersizers.Add(new Excersizer() { Id = e.Id, FirstName = e.FirstName, LastName = e.LastName,
            MobileNumber = e.MobileNumber, TrainerCode = e.TrainerCode}));
        return excersizers;
    }

    public Excersizer Get(int id)
    {
        throw new NotImplementedException();
    }

    public Excersizer Add(Excersizer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Excersizer Update(Excersizer entity)
    {
        throw new NotImplementedException();
    }
}