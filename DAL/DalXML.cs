﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;

namespace DAL
{
    internal class DalXML : IDal
    {
        private static int serialGuestRequest;
        private static int serialOrder;
        private static double commision;  //10 shekels -- zol meod public DalXML()
        private static string serialHostingUnit;

        public DalXML()
        {
            serialOrder = Int32.Parse(DataSource.DataSourceXML.Orders.Element("lastSerial").Value);
            serialGuestRequest = Int32.Parse(DataSource.DataSourceXML.GuestRequests.Element("lastSerial").Value);
            // TO DO
        }
        public bool addGuestRequest(GuestRequest gr)
        {
            XElement guestRequestElement = XElement.Parse(gr.ToXMLstring());
            DataSource.DataSourceXML.GuestRequests.Element("lastSerial").Value = guestRequestElement.Element("GuestRequestKey").Value;
            DataSource.DataSourceXML.SaveGuestRequests();
            DataSource.DataSourceXML.GuestRequests.Add(guestRequestElement);
            DataSource.DataSourceXML.SaveGuestRequests();
            return true;
        }

        public bool addHost(Host host)
        {
            DataSource.DataSourceXML.Hosts.Add(XElement.Parse(host.ToXMLstring()));
             DataSource.DataSourceXML.SaveHosts();
            DataSource.DataSourceXML.Hosts.Element("lastSerial").Value = host.HostKey.ToXMLstring();
            DataSource.DataSourceXML.SaveHosts();
            return true;
        }

        public bool addHostingUnit(HostingUnit HostingUnit)
        {
            throw new NotImplementedException();
        }

        public bool addOrder(Order neworder)
        {
            // XElement findOrder = (from o in DataSource.DataSourceXML.Orders.Elements("Order")
            //                      where Int32.Parse(o.Element("OrderKey").Value) == neworder.OrderKey
            //                      select o).FirstOrDefault();
            //if(findOrder!=null)
            //{
            //    //throw new Exception("order alraedy exist");
            //    return false;
            //}
            neworder.OrderKey = serialOrder++;
            DataSource.DataSourceXML.Orders.Add(neworder.ToXML());
            DataSource.DataSourceXML.SaveOrders();
            DataSource.DataSourceXML.Orders.Element("lastSerial").Value = neworder.OrderKey.ToString();
            DataSource.DataSourceXML.SaveOrders();
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
            return (from o in DataSource.DataSourceXML.Hosts.Elements("Host")
                    select o.ToString().ToObject<Host>()).ToList();
        }

        public List<Order> getAllorders()
        {
            return (from o in DataSource.DataSourceXML.Orders.Elements("Order")
                          select o.ToString().ToObject<Order>()).ToList();
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
            Order result = null;
            XElement findOrder = (from o in DataSource.DataSourceXML.Orders.Elements("Order")
                                  where Int32.Parse(o.Element("OrderKey").Value) == id
                                  select o).FirstOrDefault();
            if (findOrder != null)
            {
                 result = findOrder.ToString().ToObject<Order>();
            }

            return result;

        }

        public string getserialGuestRequest()
        {
            String result = DataSource.DataSourceXML.GuestRequests.Element("lastSerial").Value;
            return result;
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
            XElement findOrder = (from o in DataSource.DataSourceXML.Orders.Elements("Order")
                                  where Int32.Parse(o.Element("OrderKey").Value) == updateorder.OrderKey
                                  select o).FirstOrDefault();

            if (findOrder == null)
            {
                return false;
            }
            //TO DO
            return true;
        }
    }
}
