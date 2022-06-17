using System;
using System.Collections.Generic;
using System.Text;

namespace TEsting
{
    public class Program
    {
        static void Main(string[] args)
        {
            I_S.s_S(123);

        }
    }

    public static class I_S
    {
        public static void s_S(int number)
        {
            int number1 = number;
            int number2 = number;
            int number3 = number;

            int quotient;
            int i = 1, j;
            char[] hexadecimalNumber = new char[100];
            char temp1;

            quotient = number1;
            while (quotient != 0)
            {
                int temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                quotient = quotient / 16;
            }

            StringBuilder value = new StringBuilder();

            for (j = i - 1; j > 0; j--)
                value.Append(hexadecimalNumber[j]);

            Console.Write("16 lik sanoq sistemasida: ");
            Console.WriteLine(value);
            //********************************************************************/

            string result;

            result = "";
            while (number2 > 1)
            {
                int remainder = number2 % 2;
                result = Convert.ToString(remainder) + result;
                number2 /= 2;
            }
            result = Convert.ToString(number2) + result;

            Console.Write("2 lik sanoq sistemasidagi ko'rinishi: ");
            Console.WriteLine(result);

            //***********************************************************************/

            int i1, j1, octal = 0;
            i1 = 1;

            for (j1 = number3; j1 > 0; j1 = j1 / 8)
            {
                octal = octal + (j1 % 8) * i1;
                i1 = i1 * 10;
                number3 = number3 / 8;
            }

            Console.Write("8 lik sanoq sistemasigagi ko'rinishi: ");
            Console.WriteLine(octal);
        }

    }

}


