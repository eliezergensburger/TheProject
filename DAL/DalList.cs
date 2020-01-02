﻿using System;
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
        public bool addOrder(Order order)
        {
            if (DataSourceList.Orders.Any(mishehu => mishehu.OrderKey == order.OrderKey))
            {
                return false;
            }
            DataSourceList.Orders.Add(order.Clone());
            return true;
        }

        public Order getOrder(int id)
        {
            Order result = (from o in DataSourceList.Orders
                            where o.OrderKey == id
                            select o).FirstOrDefault();

            return result.Clone();
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

                findOrder = updateorder.Clone();
                return true;
            }
            return false;
        }
    }
}
