using BE;

namespace BL
{
    public interface Ibl
    {
        bool AddOrder(Order neworder);
        bool AddGuestRequest(GuestRequest guestRequest);
    }
}