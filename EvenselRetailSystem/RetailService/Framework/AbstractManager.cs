using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetailService.Framework
{
    public abstract class AbstractManager<T> where T :Entity
    {
        public abstract int AddNew(T obj);
        public abstract List<T> SelectAll();
        public abstract T GetByID(int ID);
        public abstract void Delete(int ID);
        
        
    }
}
