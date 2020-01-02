using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace DAL
{
    public static class BE_Extensions
    {
        /// <summary>
        /// doesn't work with nested classes as proofedint ToolsTests
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        //public static T Clone<T>(this T t) where T : class, new()
        //{
        //    T result = new T();
        //    if (t.GetType().Name != "BE.Person")
        //    {

        //        result = new T();
        //        foreach (PropertyInfo item in t.GetType().GetProperties())
        //        {
        //            item.SetValue(result, item.GetValue(t, null));
        //        }
        //    }
        //    return result;
        //}

        public static Order Clone(this Order order)
        {
            return new Order
            {
                OrderKey = order.OrderKey,
                Status = order.Status,
                CreateDate = order.CreateDate,
                GuestRequestKey = order.GuestRequestKey,
                HostingUnitKey = order.HostingUnitKey,
                OrderDate = order.OrderDate
            };
        }
        public static XElement ToXML(this Order d)
        {
            return new XElement("Order",
                                 new XElement("OrderKey", d.OrderKey.ToString()),
                                 new XElement("HostingUnitKey", d.HostingUnitKey.ToString()),
                                 new XElement("GuestRequestKey", d.GuestRequestKey.ToString()),
                                 new XElement("CreateDate", d.CreateDate.ToString()),
                                 new XElement("OrderDate", d.OrderDate.ToString()),
                                 new XElement("Status", d.Status.ToString())
                                  );
        }

        public static XElement ToXML(this BattlePlayer b)
        {
            return new XElement("BattlePlayer",
                                 new XElement("Name", b.Name.ToString()),
                                 new XElement("Board",
                                        (from v in b.Board.ToString()
                                             select v).ToArray(),
                                        (from v in b.OpponentBoard.ToString()
                                             select v).ToArray()
                                     )
                                 );
        }

        public static void SaveToXML<T>(T source, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
            xmlSerializer.Serialize(file, source);
            file.Close();
        }

        public static T LoadFromXML<T>(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T result = (T)xmlSerializer.Deserialize(file);
            file.Close();
            return result;
        }

        public static string ToXMLstring<T>(this T toSerialize)
        {
            using (StringWriter textWriter = new StringWriter())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
        public static T ToObject<T>(this string toDeserialize)
        {
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(textReader);
            }
        }


    }
}