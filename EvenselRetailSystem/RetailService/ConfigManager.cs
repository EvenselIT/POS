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

        public override void Delete(int ID)
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
                    context.SaveChanges();
                }
            }
        }

        public override void Update(Config obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Configs
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    var value = query.SingleOrDefault();
                    value.Value = obj.Value;

                    context.SaveChanges();
                }
            }
        }
    }
}
