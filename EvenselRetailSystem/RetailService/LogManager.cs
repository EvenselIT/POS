using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class LogManager : AbstractManager<Log>
    {
        public override int AddNew(Log obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToLogs(obj);
                context.SaveChanges();
            }
            return 1;
        }

        public override List<Log> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from i in context.Logs
                            select i;

                if (query != null)
                {
                    return query.ToList<Log>();
                }
                return null;
            }
        }

        public override Log GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from i in context.Logs
                            where i.ID == ID
                            select i;

                if (query != null)
                {
                    return query.FirstOrDefault();
                }
                return null;
            }
        }

        public override bool? Delete(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from i in context.Logs
                            where i.ID == ID
                            select i;

                if (query != null)
                {
                    context.Logs.DeleteObject(query.FirstOrDefault());
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }
        }

        public override bool? Update(Log obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from i in context.Logs
                            where i.ID == obj.ID
                            select i;

                if (query != null)
                {
                    context.DeleteObject(query.FirstOrDefault());
                    context.AddToLogs(obj);
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }
        }
    }
}
