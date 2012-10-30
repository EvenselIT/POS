using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class SupplierManager: AbstractManager<Supplier>
    {

        public override int AddNew(Supplier obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToSuppliers(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Supplier> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Suppliers
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }

            return null;
        }

        public override Supplier GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Suppliers
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
                var query = from n in context.Suppliers
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

        public override bool? Update(Supplier obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Suppliers
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    context.AddToSuppliers(obj);
                    context.ObjectStateManager.ChangeObjectState(obj, System.Data.EntityState.Modified);
                    context.SaveChanges();
                }
                return null;
            }
        }
    }
}
