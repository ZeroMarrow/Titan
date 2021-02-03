using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using printer = System.Console;
namespace Titan
{
    class Program
    {
        static void Main(string[] args)
        {
            string rub = " Р";
            Money m = new Money();
            m.Nominal = 100;
            Console.WriteLine(m.Nominal + rub);
            m.Quantity = 20;
            Console.WriteLine(m.Quantity);
            m.Sum = (m.Nominal * m.Quantity);
            Console.WriteLine(m.Sum + rub);
            Console.Read();
        }
    }
}
