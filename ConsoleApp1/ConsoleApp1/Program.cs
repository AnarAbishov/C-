using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldPrice = Convert.ToDouble(Console.ReadLine());
            double newPrice = Convert.ToDouble(Console.ReadLine());
            double netice = Topla(oldPrice, newPrice);
            Console.WriteLine(netice+"%");
            
        }
        static double Topla(double oldPrice, double newPrice)
        {
            return (oldPrice - newPrice) / (oldPrice / 100);
        }
    }
}
