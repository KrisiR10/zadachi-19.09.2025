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
            //zadacha 1

            Console.WriteLine("Izberi figura za namirane na lice:");
            Console.WriteLine("1. Kvadrat");
            Console.WriteLine("2. Pravougulnik");
            Console.WriteLine("3. Krug");
            Console.WriteLine("4. Triugulnik");
            Console.WriteLine("5. Usporednik");
            Console.WriteLine("6. Trapec");
            Console.WriteLine("7. Triugulnik po 3 strani");

            int choice = int.Parse(Console.ReadLine());
            double area = 0;

            switch (choice)
            {
                case 1: //kvadrat
                    Console.Write("Vuvedi strana a: ");
                    double a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;

                case 2: //pravougulnik
                    Console.Write("Vuvedi strana a: ");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi strana b: ");
                    double sideB = double.Parse(Console.ReadLine());
                    area = sideA * sideB;
                    break;

                case 3: //krug
                    Console.Write("Vuvedi r: ");
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(r, 2);
                    break;

                case 4: //triugulnik
                    Console.Write("Vuvedi a: ");
                    double sideAA = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi ha: ");
                    double ha = double.Parse(Console.ReadLine());
                    area = 0.5 * sideAA * ha;
                    break;

                case 5: //usporednik
                    Console.Write("Vuvedi a: ");
                    double sideAAA = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi h: ");
                    double h = double.Parse(Console.ReadLine());
                    area = sideAAA * h;
                    break;

                case 6://trapec
                    Console.Write("Vuvedi a: ");
                    double sideAAAA = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi b: ");
                    double sideBB = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi h: ");
                    double hh = double.Parse(Console.ReadLine());
                    area = (sideAAAA + sideBB) * hh / 2;
                    break;

                case 7://triugulnik po 3 strani
                    Console.Write("Vuvedi strana a: ");
                    double a3 = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi strana b: ");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.Write("Vuvedi strana c: ");
                    double c3 = double.Parse(Console.ReadLine());
                    double p = (a3 + b3 + c3) / 2;
                    area = Math.Sqrt(p * (p - a3) * (p - b3) * (p - c3));
                    break;
            }
            Console.WriteLine($"Liceto e: {area:F2}");

        }
    }
}
