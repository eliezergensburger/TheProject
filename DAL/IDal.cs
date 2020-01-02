using BE;

namespace DAL
{
    public interface IDal
    {
        bool addOrder(Order order);
        Order getOrder(int id);
        bool updateOrder(Order order);
    }
}