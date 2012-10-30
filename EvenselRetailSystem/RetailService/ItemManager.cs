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

        public override bool? Delete(int ID)
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
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }
        }

        #endregion

        public override bool? Update(Item obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.Items.AddObject(obj);
                context.ObjectStateManager.ChangeObjectState(obj, System.Data.EntityState.Modified);
                return IsChanged(context.SaveChanges());
            }
        }
    }
}
