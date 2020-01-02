using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataSource
{
    public static class DataSourceXML
    {
        //private static string currentDirectory = Directory.GetCurrentDirectory();
        private static string solutionDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;

        private static string filePath = System.IO.Path.Combine(solutionDirectory, "DataSource", "DataXML");


        private static XElement orderRoot = null;
        private static XElement guestRequestRoot = null;
        private static XElement drivingtestRoot = null;


        private static string orderPath = Path.Combine(filePath, "OrderXml.xml");
        private static string guestRequestPath = Path.Combine(filePath, "GuestRequestXml.xml");
        private static string drivingtestPath = Path.Combine(filePath, "DrivingtestXml.xml");

        static DataSourceXML()
        {
            bool exists = Directory.Exists(filePath);
            if (!exists)
            {
                Directory.CreateDirectory(filePath);
            }

            if (!File.Exists(orderPath))
            {
                CreateFile("Orders", orderPath);

            }
            orderRoot = LoadData(orderPath);


            if (!File.Exists(guestRequestPath))
            {
                CreateFile("GuestRequests", guestRequestPath);

            }
            guestRequestRoot = LoadData(guestRequestPath);

            if (!File.Exists(drivingtestPath))
            {
                CreateFile("DrivingTests", drivingtestPath);

            }
            drivingtestRoot = LoadData(drivingtestPath);

        }
        private static void CreateFile(string typename, string path)
        {
            XElement root = new XElement(typename);
            root.Save(path);
        }

        public static void SaveOrders()
        {
            orderRoot.Save(orderPath);
        }

        public static void SaveGuestRequests()
        {
            guestRequestRoot.Save(guestRequestPath);
        }

        public static void SaveDrivingtests()
        {
            drivingtestRoot.Save(drivingtestPath);
        }

        public static XElement Orders
        {
            get
            {
                orderRoot = LoadData(orderPath);
                return orderRoot;
            }
        }

        public static XElement GuestRequests
        {
            get
            {
                guestRequestRoot = LoadData(guestRequestPath);
                return guestRequestRoot;
            }
        }

        public static XElement DrivingTests
        {
            get
            {
                drivingtestRoot = LoadData(drivingtestPath);
                return drivingtestRoot;
            }
        }

        private static XElement LoadData(string path)
        {
            XElement root;
            try
            {
                root = XElement.Load(path);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
            return root;
        }


    }
}
