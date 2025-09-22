using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 5
            Console.Write("Vuvedete godishnata taksa za trenirovka po ski: ");
            double fee = double.Parse(Console.ReadLine());

            double ski = fee * 0.60;
            double equipment = ski * 0.80;
            double helmet = equipment / 4.0;
            double accessories = helmet / 5.0;

            double total = fee + ski + equipment + helmet + accessories;

            Console.WriteLine($"total = { total:F2}");
        }
    }
}
