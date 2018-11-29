using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstTry
{
     public interface IBaseDao<T> where T : class,new()
    {

        IQueryable<T> LoadEntites();  //gain
        T AddEntity(T entity);  //add  
        T UpdateEntity(T entity); //update 
        bool DelEntity(T entity); //delete
        bool DelEntityByWhere(Func<T, bool> whereLambda); //delete according conmand
    }
}
