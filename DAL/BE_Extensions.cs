using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public static class BE_Extensions
    {
        public static Order Clone(this Order order)
        {
            return new Order
            {
                Id = order.Id,
                Status = order.Status
            };
        }
    }
}
