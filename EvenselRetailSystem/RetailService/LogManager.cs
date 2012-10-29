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
            throw new NotImplementedException();
        }

        public override Log GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public override void Update(Log obj)
        {
            throw new NotImplementedException();
        }
    }
}
