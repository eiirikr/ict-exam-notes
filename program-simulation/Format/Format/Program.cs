using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value); // 81.0372771474878
            Console.WriteLine(string.Format("{0:0}", value)); // 81
            Console.WriteLine(string.Format("{0:0.0}", value)); // 81.0
            Console.WriteLine(string.Format("{0:0.#}", value)); // 81
            Console.WriteLine(string.Format("{0:0.00}", value));// 81.04

            double money = 10D / 3D;
            Console.WriteLine(string.Format("₱10 / ₱3 = ₱{0:0.00}", money)); // ₱10 / ₱3 = ₱3.33

            money = -10D / 3D;
            Console.WriteLine(string.Format("-₱10 / ₱3 = ₱{0:0.00}", money)); // -₱10 / ₱3 = ₱-3.33
            Console.WriteLine(money.ToString("C")); // -₱3.33
            Console.WriteLine(money.ToString("C0")); // -₱3
            Console.WriteLine(money.ToString("C1")); // -₱3.3
            Console.WriteLine(money.ToString("C2")); // -₱3.33

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));

            Console.ReadLine();
        }
    }
}
