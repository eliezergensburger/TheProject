using BE;
using System;
using System.Collections.Generic;

namespace DAL
{
    public interface IDal
    {
        string getserialGuestRequest();

        bool addOrder(Order order);
        Order getOrder(int id);
        List<Order> getAllorders();
        bool updateOrder(Order order);
        bool addGuestRequest(GuestRequest gr);
    }
}