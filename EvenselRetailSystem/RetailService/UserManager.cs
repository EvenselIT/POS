using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace RetailService
{
    class UserManager : AbstractManager <User>
    {
        public override int AddNew(User obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToUsers(obj);
            }

            return 1;
        }

        public override List<User> SelectAll()
        {
            throw new NotImplementedException();
        }

        public override User GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
