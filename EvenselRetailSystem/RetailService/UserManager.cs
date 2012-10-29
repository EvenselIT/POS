using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class UserManager : AbstractManager <User>
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
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Users
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }
            return null;
        }

        public override User GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Users
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
                var query = from n in context.Users
                            where n.ID == ID
                            select n;

                if (query != null)
                {
                    User user =  query.SingleOrDefault();
                    context.DeleteObject(user);
                    context.SaveChanges();
                }
            }
        }

        public override void Update(User obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Users
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    User oldUser = query.SingleOrDefault();
                    // check user object are not equal
                    if (true )
                    {
                       // update code should go hear
                    }
                    
                }
                
            }
            
        }
        //userauthentication
        public List<Role> UserAuthentication(string username, string password)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                List<Role> UsersroleList = new List<Role>();
                var usrId = from n in context.Users
                            where n.UserName == username && n.Password == password
                            select n.ID;

                if (usrId != null)
                {
                    var roleIds = from n in context.UserRoles
                                where n.UserID.Equals(usrId)
                                select n.RoleID;
                    
                    if (roleIds != null)
                    {
                        foreach (var id in roleIds)
                        {
                            var usrRole = from n in context.Roles
                                        where n.ID == id
                                        select n;
                            
                            if (usrRole != null)
                            {
                                UsersroleList.Add((Role)usrRole);
                            }
                        }

                        return UsersroleList;
                                              
                    }                 

                }
               
            }

            return null;
            
         }

    }
}
