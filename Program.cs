using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete marka kola: ");
            string model = Console.ReadLine();

            Console.Write("Vuvedete izminati kilometri: ");
            double km = double.Parse(Console.ReadLine());

            Console.Write("Vuvedete razhod gorivo: ");
            double fuel = double.Parse(Console.ReadLine());

            double srednaSkorost = (fuel / km) * 100;
            Console.WriteLine("Vashiqt sreden razhod za 100km e" + " " + srednaSkorost + "l/km, vse pak e " + model + "!");
        }
    }
}
