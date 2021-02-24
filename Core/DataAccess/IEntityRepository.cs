using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //class : referans tip
    // IEntity  : IEntity olabilir veya onu implement eden bir sistem olabilir
    // new : new  lenebilir olması lazım 
   public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter= null);
        
        T Get(Expression<Func<T, bool>> filter = null);
       
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
       
     

       
    }
}
