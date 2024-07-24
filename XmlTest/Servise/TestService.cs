using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlTest.Model;
using static XmlTest.Configuration.Configuration;

namespace XmlTest.Servise
{
    internal class TestService
    {

        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(TestPath))
            {
                XDocument document = new();
                XElement test = new(@"date-test");
                document.Add(test);
                document.Save(TestPath);
            }
        }
        public static void AddDate(DateModel dateModel)
        {
            XDocument document = XDocument.Load(TestPath);
            XElement? DateTest = document.Descendants("date-test")
                .FirstOrDefault();
            if (DateTest == null) return;
            XElement? day = new("day", dateModel.DayInWeek);
            XElement? dayinmonth = new("dayinmonyh", dateModel.DayInMonth);
            XElement? month = new("month", dateModel.Month);
            XElement? year = new("year", dateModel.Year);
            XElement? result = new("result",dateModel.result);
            DateTest.Add(day,dayinmonth,month,year,result);
            document.Save(TestPath);
        }
    }
}
