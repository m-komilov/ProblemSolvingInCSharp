using System;
using System.Collections.Generic;
using System.Text;

namespace TEsting
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder matnlar = new StringBuilder(
                "Assalom 1 deganda 2 ochilar 3 deganda 4 qo'shilar hullas 5 ga 6 ni qo'shsak 7 bo'lmas haha"
                );
            raqam(matnlar);
            

        }

        static void raqam(StringBuilder matnlar)
        {
            StringBuilder numberMatnlari = new StringBuilder();

            for (int i = 0; i < matnlar.Length; i++)
            {
                if (matnlar[i] == '0' || matnlar[i] == '1' || matnlar[i] == '2' || matnlar[i] == '3' || matnlar[i] == '4' || matnlar[i] == '5' || matnlar[i] == '6' || matnlar[i] == '7' || matnlar[i] == '8' || matnlar[i] == '9')
                {
                    numberMatnlari.Append(matnlar[i].ToString());
                }
            }
            Console.WriteLine(numberMatnlari);
        }
    }

}


