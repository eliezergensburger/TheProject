using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DataSource;

namespace DAL
{
    internal class DalList : IDal
    {
        private static string serialGuestRequest = "10000000";
        private static double commision = 10;    //10 shekels -- zol meod
        private static string  serialHostingUnit = "10000000";

        public bool addGuestRequest(GuestRequest gr)
        {
            throw new NotImplementedException();
        }

        public bool addHost(Host host)
        {
            throw new NotImplementedException();
        }

        public bool addHostingUnit(HostingUnit HostingUnit)
        {
            throw new NotImplementedException();
        }

        public bool addOrder(Order order)
        {
            if (DataSourceList.Orders.Any(mishehu => mishehu.OrderKey == order.OrderKey))
            {
                return false;
            }
            DataSourceList.Orders.Add(order.Clone());
            return true;
        }

        public List<GuestRequest> getAllGuestRequests()
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> getAllHostingUnits()
        {
            throw new NotImplementedException();
        }

        public List<Host> getAllHosts()
        {
            throw new NotImplementedException();
        }

        public List<Order> getAllorders()
        {

            //TO DO
            //deep clone
            var result = from o in DataSourceList.Orders
                         select o.Clone();

            return result.ToList();
        }

        public GuestRequest getGuestRequest(int id)
        {
            throw new NotImplementedException();
        }

        public Host getHost(int id)
        {
            throw new NotImplementedException();
        }

        public HostingUnit getHostingUnit(int id)
        {
            throw new NotImplementedException();
        }

        public Order getOrder(int id)
        {
            Order result = (from o in DataSourceList.Orders
                            where o.OrderKey == id
                            select o).FirstOrDefault();

            return result.Clone();
        }

        public string getserialGuestRequest()
        {
            return serialGuestRequest;
        }

        public bool updateGuestRequest(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }

        public bool updateHost(Host host)
        {
            throw new NotImplementedException();
        }

        public bool updateHostingUnit(HostingUnit HostingUnit)
        {
            throw new NotImplementedException();
        }

        public bool updateOrder(Order updateorder)
        {
            Order findOrder = (from o in DataSourceList.Orders
                               where o.OrderKey == updateorder.OrderKey
                               select o).FirstOrDefault();
            if (findOrder != null)
            {
                //findOrder.GuestRequestKey = updateorder.GuestRequestKey;
                //findOrder.HostingUnitKey = updateorder.HostingUnitKey;
                //findOrder.OrderDate = updateorder.OrderDate;
                //findOrder.Status = updateorder.Status;

                // courtesy of Raphael Ohana 
                findOrder = updateorder.Clone();
                return true;
            }
            return false;
        }
    }
}
