using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class SalesManager : AbstractManager<Sale>
    {
        public override int AddNew(Sale obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToSales(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Sale> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Sales
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }

            return null;
        }

        public override Sale GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.ContextOptions.LazyLoadingEnabled = false;

                var query = from n in context.Sales
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
                var query = from n in context.Sales
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

        public override bool? Update(Sale obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Sales
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    context.AddToSales(obj);
                    context.ObjectStateManager.ChangeObjectState(obj, System.Data.EntityState.Modified);
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }
        }
    }
}
