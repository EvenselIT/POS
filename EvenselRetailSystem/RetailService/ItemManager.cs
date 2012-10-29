using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class ItemManager : AbstractManager<Item>
    {
        #region Basic CRUD operation

        public override int AddNew(Item obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToItems(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Item> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Items
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }

            return null;
        }

        public override Item GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Items
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
                var query = from n in context.Items
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
    }
}
