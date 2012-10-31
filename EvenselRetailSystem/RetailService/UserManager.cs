using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class UserManager : AbstractManager <User>
    {
        //Adding a New Customer
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

                return null;
            }
        }

        public override bool? Delete(int ID)
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
                    return IsChanged(context.SaveChanges());
                }

                return null;
            }
        }

        public override bool? Update(User obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Users
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    context.Users.DeleteObject(query.FirstOrDefault());
                    context.AddToUsers(obj);
                    return IsChanged(context.SaveChanges());
                }
                return null;
            }            
        }

        /// <summary>
        /// Retrive User ID When User Name is Given
        /// </summary>
        /// <param name="userName">Current UserName of the User</param>
        /// <returns>Return User ID If Found Else Retrun null</returns>
        public string GetUserID(string userName)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from i in context.Users
                            where i.UserName == userName
                            select i.ID;

                if (query.Count() != 0)
                {
                    return query.FirstOrDefault().ToString();
                }

                return null;
            }
        }

        /// <summary>
        /// User Authentcation and retrive the level of roles assigned to the user 
        /// </summary>
        /// <param name="username">UserName</param>
        /// <param name="password">Password</param>
        /// <returns>Return List of Role</returns>
        public List<Role> UserAuthentication(string username, string password)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                List<Role> UsersroleList = new List<Role>();
                var usrId = from n in context.Users
                            where n.UserName == username && n.Password == password
                            select n.ID;

                if (usrId.Count() != 0)
                {
                    var roleIds = from n in context.UserRoles
                                where n.UserID == usrId.FirstOrDefault()
                                select n.RoleID;
                    
                    if (roleIds.Count() != 0)
                    {
                        foreach (var id in roleIds)
                        {
                            var usrRole = from n in context.Roles
                                        where n.ID == id
                                        select n;
                            
                            if (usrRole != null)
                            {
                                UsersroleList.Add((Role)usrRole.FirstOrDefault());
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
