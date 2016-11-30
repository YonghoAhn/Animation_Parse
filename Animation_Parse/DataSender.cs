using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation_Parse
{
    class DataSender
    {
        public string Full_HTML { get; set; }
        public static List<Tuple<string, string[], string>> Mon { get; set; }
        public static List<Tuple<string, string[], string>> Tue { get; set; }
        public static List<Tuple<string, string[], string>> Wed { get; set; }
        public static List<Tuple<string, string[], string>> Thu { get; set; }
        public static List<Tuple<string, string[], string>> Fri { get; set; }
        public static List<Tuple<string, string[], string>> Sat { get; set; }
        public static List<Tuple<string, string[], string>> Sun { get; set; }

    }
}
