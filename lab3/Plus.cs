using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Plus
    {
        public double num1 = 0.0; //properties
        public double num2 = 0.0;
        public Plus(double num1, double num2)//constructor
        {
            this.num1 = num1;//Dependency
            this.num2 = num2;//Dependency
        }
        public double Shownumber1()
        {
            return this.num1;
        }
        public double Shownumber2()
        {
            return this.num2;
        }
        public double summary()
        {
            return this.num1 + this.num2;


        }
    }
}
