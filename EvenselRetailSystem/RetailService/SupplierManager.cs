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

        public override void Delete(int ID)
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
                    context.SaveChanges();
                }
            }
        }

        public override void Update(Supplier obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Suppliers
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    var selectedObject = query.SingleOrDefault();

                    selectedObject.SupplierName = obj.SupplierName;
                    selectedObject.Tel = obj.Tel;
                    selectedObject.AccountNo = obj.AccountNo;
                    selectedObject.Address = obj.Address;


                    context.SaveChanges();
                }
            }
        }
    }
}
