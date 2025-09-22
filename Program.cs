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
            //zadacha 3
            Console.WriteLine("Vuvedi Ime na firmata: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Vuvedi Adres na firmata: ");
            string address = Console.ReadLine();
            Console.WriteLine("Vuvedi Tel. nomer na firmata: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Vuvedi Faks nomer na firmata: ");
            string fax = Console.ReadLine();
            Console.WriteLine("Vuvedi WebSite na firmata: ");
            string website = Console.ReadLine();

            Console.WriteLine("Vuvedi Ime na menidjura: ");
            string menijerIme = Console.ReadLine();
            Console.WriteLine("Vuvedi familiq na menidjura: ");
            string menijerFamiliq = Console.ReadLine();
            Console.WriteLine("Vuvedi tel. nomer na menidjura: ");
            string menijerPhone = Console.ReadLine();

            Console.WriteLine("---Vizitka---");
            Console.WriteLine("Firma: "+companyName);
            Console.WriteLine("Adres: " + address);
            Console.WriteLine("Tel.nomer: " + phone);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("Website: " + website);
            Console.WriteLine("Menidjer: " + menijerIme + " " + menijerFamiliq + " " + "Telefon" + " " + menijerPhone);
        }
    }
}
