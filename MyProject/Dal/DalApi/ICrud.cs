using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    internal interface ICrud<T>
    {
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);

       
    }
}
