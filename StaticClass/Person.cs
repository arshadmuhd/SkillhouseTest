using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static string Weather { get; set; }
        public static string WeatherInfo()
        {
            return Weather;
        }
    }
}
