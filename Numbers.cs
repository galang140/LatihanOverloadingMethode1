using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethode1
{
   public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return (number2 < number1) ? number2 : number1;
        }

        public int FindMinimum(int number1, int number2, int number3)
        {
            if (number1 < number2 && number2 < number3)
            {
                return number1;
            }
            else if (number2 < number1 && number2 < number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }

        public int FindMaximum(int number1, int number2)
        {
            return (number2 > number1) ? number2 : number1;
        }

        public int FindMaximum(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
