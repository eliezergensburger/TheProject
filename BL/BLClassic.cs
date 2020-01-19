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
        public BLClassic()
        {
            IDal intance = FactorySingletonDal.Instance;
            Configuration.serialGuestRequest = Int32.Parse(intance.getserialGuestRequest());
        }
        public bool AddGuestRequest(GuestRequest guestRequest)
        {
            //put verifications here
            guestRequest.GuestRequestKey = Configuration.serialGuestRequest;
            FactorySingletonDal.Instance.addGuestRequest(guestRequest);
            ++(Configuration.serialGuestRequest);
            return true;
        }

        public bool AddHost(Host host)
        {
            IDal instance = FactorySingletonDal.Instance;
            if (instance.getAllHosts().Any(h => h.HostKey == host.HostKey))
            {
                return false;
            }

            instance.addHost(host);

            return true;

        }

        public bool AddHostingUnit(HostingUnit hostingUnit)
        {
            IDal instance = FactorySingletonDal.Instance;
            throw new NotImplementedException();
        }

        public bool AddOrder(Order neworder)
        {
            IDal instance = FactorySingletonDal.Instance;

            // do all kind of verifications accordind to BL logic

           // Order order = instance.getOrder(neworder.OrderKey);
           // if(order != null)
            if (instance.getAllorders().Any(o => o.OrderKey == neworder.OrderKey))
            {
                return false;
            }

            instance.addOrder(neworder);

            return true;
        }
    }
}
