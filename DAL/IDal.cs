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

        bool addHost(Host host);
        Host getHost(int id);
        List<Host> getAllHosts();
        bool updateHost(Host host);

        bool addHostingUnit(HostingUnit HostingUnit);
        HostingUnit getHostingUnit(int id);
        List<HostingUnit> getAllHostingUnits();
        bool updateHostingUnit(HostingUnit HostingUnit);

        bool addGuestRequest(GuestRequest guestRequest);
        GuestRequest getGuestRequest(int id);
        List<GuestRequest> getAllGuestRequests();
        bool updateGuestRequest(GuestRequest guestRequest);


    }
}