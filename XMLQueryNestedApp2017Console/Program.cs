using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLQueryNestedApp2017Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetFileXml(@"XmlFile\search.xml");
            var x2 = x.SelectSingleNode("QUERY/CitySearch");
        }
        public static XmlDocument GetFileXml(string FileName)
        {
            try
            {

                string pathFile = FileName;
                XmlDocument obj = new XmlDocument();
                obj.Load(pathFile);
                return obj;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
