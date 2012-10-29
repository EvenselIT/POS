using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetailService.Framework;

namespace Evensel.RetailService
{
    public class GiftManager : AbstractManager<Gift>
    {
        public override int AddNew(Gift obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                context.AddToGifts(obj);
            }

            return 1;
        }

        public override List<Gift> SelectAll()
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Gifts
                            select n;

                if (query != null)
                {
                    return query.ToList();
                }
            }
            return null;
        }

        public override Gift GetByID(int ID)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Gifts
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
                var query = from n in context.Gifts
                            where n.ID == ID
                            select n;

                if (query != null)
                {
                    var user = query.SingleOrDefault();
                    context.DeleteObject(user);
                    context.SaveChanges();
                }
            }
        }

        public override void Update(Gift obj)
        {
            using (EvenselPOSEntities context = new EvenselPOSEntities())
            {
                var query = from n in context.Gifts
                            where n.ID == obj.ID
                            select n;

                if (query != null)
                {
                    var gift = query.SingleOrDefault();
                    gift.GiftNumber = obj.GiftNumber;
                    gift.Value = obj.Value;

                    context.SaveChanges();
                }
            }
        }
    }
}
