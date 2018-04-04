using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using Data;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Database db = new Database();
        }
    }
}
