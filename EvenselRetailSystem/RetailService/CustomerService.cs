using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class CustomerService : AbstractManager<Customer>
    {
        #region Basic CRUD Opearations

        public override int AddNew(Customer obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToCustomers(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Customer> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Customers
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }

            return null;
        }

        public override Customer GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Customers
                            where n.ID == ID
                            select n;

                if (query != null)
                {
                    return query.SingleOrDefault();
                }
            }

            return null;
        }

        public override bool? Delete(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Customers
                            where n.ID == ID
                            select n;

                if (query != null)
                {
                    var selectedObject = query.SingleOrDefault();
                    context.DeleteObject(selectedObject);
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }
        }

        #endregion

        /// <summary>
        /// Update Customer Details
        /// </summary>
        /// <param name="obj">New Customer Object</param>
        /// <returns>Return true if suceed else retrun false, If Customer Not Found Return null</returns>
        public override bool? Update(Customer obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                //var query = from i in context.Customers
                //            where i.ID == obj.ID
                //            select i;
                

                //if (query != null)
                //{

                context.AddToCustomers(obj);
                context.ObjectStateManager.ChangeObjectState(obj, System.Data.EntityState.Modified);
                return IsChanged(context.SaveChanges());
                //}
                //return null;
            }
        }

        /// <summary>
        /// Get Maximul Value From the Customer
        /// </summary>
        /// <returns>Max Customer ID</returns>
        public int getMaxCustomerID() 
        {
            int max = 1;
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = (from i in context.Customers
                             select i);

                if (query != null && query.Count()>0)
                {
                    max = query.Max(a=>a.ID);                  
                }
            }
            return max;
        }
    }
}
