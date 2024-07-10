using AutoMapper;
using Bl.BlApi;
using Bl.BlDalModels;
using Bl.BlModels;
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
    IMapper map;
    public BlExcersizersServices(DalManager instance, IMapper mapper)
    {
        this.blExcersizers = instance.Excersizers;
        this.map = mapper;
    }

    public List<BlDalExcersizer> GetAll()
    {
        List<Excersizer> excersizers = blExcersizers.GetAll();
        List<BlDalExcersizer> excersizers1 = new List<BlDalExcersizer>();
        for (int i = 0; i < excersizers.Count; i++)
        {
            excersizers1.Add(map.Map<BlDalExcersizer>(excersizers[i]));
        }
        return excersizers1;
    }

    public BlDalExcersizer Get(int id)
    {
        Excersizer ex = blExcersizers.Get(id);
        if(ex != null) 
        { 
            BlExcersizer excersizer = (BlExcersizer)map.Map<BlDalExcersizer>(ex);
            return excersizer;
        }
        return null;
    }

    public BlDalExcersizer Add(BlDalExcersizer entity)
    {
        Excersizer excersizer = map.Map<Excersizer>(entity);
        blExcersizers.Add(excersizer);
        return (BlExcersizer)entity;
    }

    public void Delete(int id)
    {
        blExcersizers.Delete(id);
    }

    public BlDalExcersizer Update(BlDalExcersizer entity)
    {
        Excersizer ex = blExcersizers.Get(entity.Id);
        if (ex != null)
        {
            blExcersizers.Update(ex);
        }
        else Add(entity);
        return (BlExcersizer)entity;
    }
}