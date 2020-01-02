using System;
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
        public bool addGuestRequest(GuestRequest gr)
        {
            throw new NotImplementedException();
        }

        public bool addOrder(Order neworder)
        {
             XElement findOrder = (from o in DataSource.DataSourceXML.Orders.Elements()
                                  where Int32.Parse(o.Element("OrderKey").Value) == neworder.OrderKey
                                  select o).FirstOrDefault();
            if(findOrder!=null)
            {
                return false;
            }
            DataSource.DataSourceXML.Orders.Add(neworder.ToXML());
            DataSource.DataSourceXML.SaveOrders();
            return true;
        }
        public Order getOrder(int id)
        {
            Order result = null;
            XElement findOrder = (from o in DataSource.DataSourceXML.Orders.Elements()
                                  where Int32.Parse(o.Element("OrderKey").Value) == id
                                  select o).FirstOrDefault();
            if (findOrder != null)
            {
                 result = findOrder.ToString().ToObject<Order>();
            }

            return result;

        }
        public bool updateOrder(Order updateorder)
        {
            XElement findOrder = (from o in DataSource.DataSourceXML.Orders.Elements()
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
