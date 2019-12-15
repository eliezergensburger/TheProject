using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Tools
    {
        public static String TostringProperties<T>(this T t)
        {
            string result = "";
            foreach(PropertyInfo p in t.GetType().GetProperties())
            {
                result += String.Format("{0,-25} , {1}\n", p.Name, p.GetValue(t, null));
            }
            return result;
        }
    }
}
