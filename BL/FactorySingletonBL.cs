using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class FactorySingletonBL
    {
        private static Ibl instance = null;

        public static Ibl getInstance()
        {
            if(instance == null)
            {
                instance = new BLClassic();
            }
            return instance;
        }
    }
}
