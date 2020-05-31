using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ege_sequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int array_dususu = 0;
            string[] arr = { "V","W","X","Y","Z" };
            array_dususu = arr.Length - 1;
            string gecici = "";
            int hesapla = arr.Length / 2;
            for (int k = 0; k < hesapla; k++)
            {
                gecici = arr[k];
                arr[k] = arr[array_dususu];
                arr[array_dususu] = gecici;
                array_dususu -= 1;
            }
            foreach(var sonuc in arr) { Console.Write(sonuc); }
        }
    }
}
