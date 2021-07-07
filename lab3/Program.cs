using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number A+B");
            Console.WriteLine("-----------------------");

            Console.Write("in put number A=");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("in put number B=");
            double num2 = Convert.ToDouble(Console.ReadLine());

            var plu = new Plus(num1, num2);

            var summary = plu.summary();
            Console.WriteLine("Summary=" + summary);
            Console.ReadLine();


            {

            }
        }
    }
}
