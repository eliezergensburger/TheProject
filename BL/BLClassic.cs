using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BL
{
    internal class BLClassic : Ibl
    {
        public bool AddGuestRequest(GuestRequest guestRequest)
        {
            //put verifications here
            guestRequest.GuestRequestKey = Configuration.serialGuestRequest++;

            FactorySingletonDal.Instance.addGuestRequest(guestRequest);
            return true;
        }

        public bool AddOrder(Order neworder)
        {
            IDal instance = FactorySingletonDal.Instance;

            // do all kind of verifications accordind to BL logic

            Order order = instance.getOrder(neworder.OrderKey);
            if (order != null)
            {
                if (order.Status == Status.CloseByApp || order.Status == Status.CloseByClient)
                {
                    return false;
                }
                else
                {
                }
            }

            instance.addOrder(neworder);

            return true;
        }
    }
}
