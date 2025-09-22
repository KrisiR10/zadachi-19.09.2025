using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 2
            Console.WriteLine("1. Milimetur kum metur:");
            Console.WriteLine("2. Kilogram kum ton:");
            Console.WriteLine("3. Vek kum godina:");
            Console.WriteLine("4. Minuti kum chasove:");
            Console.WriteLine("5. Celzii kum gradus Farenhai:");
            Console.WriteLine("6. Farenhai kum gradus Kelvin:");
            Console.WriteLine("Izberi opciq:");

            int choice = int.Parse(Console.ReadLine());
            double input, result;

            switch (choice)
            {
                case 1:
                    Console.Write("Vuvedi milimetri: ");
                    input = double.Parse(Console.ReadLine());
                    result = input / 1000.0;
                    Console.Write($"Metri: {result:F2}");
                    break;

                case 2:
                    Console.Write("Vuvedi kilogrami: ");
                    input = double.Parse(Console.ReadLine());
                    result = input / 1000.0;
                    Console.Write($"Tonove: {result:F2}");
                    break;

                case 3:
                    Console.Write("Vuvedi vekove: ");
                    input = double.Parse(Console.ReadLine());
                    result = input * 100;
                    Console.Write($"Godini: {result:F2}");
                    break;

                case 4:
                    Console.Write("Vuvedi minuti: ");
                    input = double.Parse(Console.ReadLine());
                    result = input / 60.0;
                    Console.Write($"Chasove: {result:F2}");
                    break;

                case 5:
                    Console.Write("Vuvedi celzii : ");
                    input = double.Parse(Console.ReadLine());
                    result = (input * 9 / 5) + 32;
                    Console.Write($"Gradusi Farenhai: {result:F2}");
                    break;

                case 6:
                    Console.Write("Vuvedi gradusi Farenhai: ");
                    input = double.Parse(Console.ReadLine());
                    result = (input - 32) * 5.0 / 9.0 + 273.15;
                    Console.Write($"Gradusi Kelvin: {result:F2}");
                    break;

                default:
                    Console.WriteLine("Nevalidna opciq!");
                    break;
            }
        }
    }
}
