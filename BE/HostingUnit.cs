using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BE
{
    public class HostingUnit
    {
        public int HostingUnitKey { get; private set; }
        public String Owner { get; set; }
        public String HostingUnitName { get; set; }
        public String Diary { get; set; }

        public HostingUnit()
        {
            HostingUnitKey = Configuration.serialHostingUnit++;
        }
        public override string ToString()
        {
            return this.TostringProperties();
        }
    }
}
