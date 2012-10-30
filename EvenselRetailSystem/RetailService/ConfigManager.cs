using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class ConfigManager : AbstractManager<Config>
    {
        public override int AddNew(Config obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToConfigs(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Config> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Configs
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }

            return null;
        }

        public override Config GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Configs
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
                var query = from n in context.Configs
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

        public override bool? Update(Config obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Configs
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    context.AddToConfigs(obj);
                    context.ObjectStateManager.ChangeObjectState(obj, System.Data.EntityState.Modified);
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }
        }
    }
}
