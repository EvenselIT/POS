using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Evensel.RetailService;

namespace RetailService.Framework
{
    public abstract class AbstractManager<T> where T :IEntity
    {
        public abstract int AddNew(T obj);
        public abstract List<T> SelectAll();
        public abstract T GetByID(int ID);
        public abstract bool? Delete(int ID);
        public abstract bool? Update(T obj);


        /// <summary>
        /// To Ensure the Changes to the Database Insert/ Update/ Delete
        /// </summary>
        /// <param name="value">Value from the Database after AddTo Or SaveChagne</param>
        /// <returns>If subjected to Change retrun True else False</returns>
        public bool IsChanged(int value)
        {
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
