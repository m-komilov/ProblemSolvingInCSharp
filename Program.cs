using System;
using System.Collections.Generic;
using System.Text;

namespace TEsting
{
    public class Program
    {
        static void Main(string[] args)
        {
            I_S result = new I_S();
            Console.WriteLine(result.BinaryToOctal("1010"));
            Console.WriteLine(result.BinaryToHexDecimal("101010100101010101"));

        }
    }

    public interface I_s
    {
        public int BinaryToOctal(string binary);
        public string BinaryToHexDecimal(string binary);
    }

    public class I_S : I_s
    {
        public string BinaryToHexDecimal(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return binary;

            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }

        public int BinaryToOctal(string binary)
        {
            int n1, n, p = 1;
            int dec = 0, i = 1, j, d;
            int ocno = 0;

            n = Convert.ToInt32(binary);
            n1 = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                dec = dec + (d * p);
                i++;
            }

            /*--------------------------------------------*/
            i = 1;

            for (j = dec; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                n = n / 8;
            }

            return ocno;
        }
    }

}


