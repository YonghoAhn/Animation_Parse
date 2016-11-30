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
        /*
         * List<Tuple<string,string[],string>> Mon {get;set;}
         * Mon<Tuple<이름,Group(회차목록|img src)(영상 주소)>> 하면 될듯
         */
        public static List<Tuple<string, string[][]>> Mon { get; set; }
        public static List<Tuple<string, string[][]>> Tue { get; set; }
        public static List<Tuple<string, string[][]>> Wed { get; set; }
        public static List<Tuple<string, string[][]>> Thu { get; set; }
        public static List<Tuple<string, string[][]>> Fri { get; set; }
        public static List<Tuple<string, string[][]>> Sat { get; set; }
        public static List<Tuple<string, string[][]>> Sun { get; set; }
    }
}
