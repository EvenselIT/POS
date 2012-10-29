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

        public override void Delete(int ID)
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
                    context.SaveChanges();
                }
            }
        }

        #endregion

        public override void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
