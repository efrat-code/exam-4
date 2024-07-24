using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlTest.Configuration
{
    internal class Configuration
    {
        public static string TestPath = Path.Combine(
            Directory.GetCurrentDirectory(), "testpath.xml");
    }

}
