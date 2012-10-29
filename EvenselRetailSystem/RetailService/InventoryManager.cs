using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class InventoryManager: AbstractManager<Inventory>
    {
        public override int AddNew(Inventory obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToInventories(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Inventory> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Inventories
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }

            return null;
        }

        public override Inventory GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Inventories
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
                var query = from n in context.Inventories
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

        /// <summary>
        /// update inventory, set last update date as datetime now.
        /// </summary>
        /// <param name="obj"></param>
        public override void Update(Inventory obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Inventories
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    var selectedObject = query.SingleOrDefault();

                    selectedObject.Location = obj.Location;
                    selectedObject.QtyOnHand = obj.QtyOnHand;
                    selectedObject.ReOrderLevel = obj.ReOrderLevel;
                    selectedObject.LastUpdateDate = DateTime.Now;


                    context.SaveChanges();
                }
            }
        }
    }
}
