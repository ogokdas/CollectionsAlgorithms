using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsAlgorithms
{
    internal class Program
    {

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
        AB:

            Console.Clear();
            try
            {
                Console.WriteLine("20 adet pozitif tam sayı girin");
                int[] dizi = new int[20];

                for (int i = 0; i < 20; i++)
                {
                    dizi[i] = Convert.ToInt32(Console.ReadLine());
                }
                foreach (var item in dizi)
                {
                    if (item < 0)
                    {
                        throw new OzelHata();
                    }

                }
                Console.Clear();

                ArrayList Prime = new ArrayList();
                ArrayList NotPrime = new ArrayList();

                foreach (var item in dizi)
                {
                    if (IsPrime(item))
                    {
                        Prime.Add(item);
                    }
                    else
                    {
                        NotPrime.Add(item);
                    }
                }
                Prime.Sort();
                Prime.Reverse();
                NotPrime.Sort();
                NotPrime.Reverse();

                Console.WriteLine("Asal Olanlar büyükten küçüğe");
                foreach (var item in Prime)
                {
                    Console.WriteLine(item);
                }
                System.Threading.Thread.Sleep(3000);

                Console.WriteLine("Asal Olmayanlar büyükten küçüğe");
                foreach (var item in NotPrime)
                {
                    Console.WriteLine(item);
                }

                System.Threading.Thread.Sleep(3000);

                Console.WriteLine("Asal olan dizinin eleman sayısı: {0}", Prime.Count);
                Console.WriteLine("Asal olan dizinin eleman sayısı: {0}", NotPrime.Count);

                System.Threading.Thread.Sleep(5000);





                Console.ReadLine();



            }

            catch (OzelHata fx)
            {
                
                System.Threading.Thread.Sleep(1500);

                goto AB;
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                System.Threading.Thread.Sleep(1500);


                goto AB;


            }

            


        }
    }

    public class OzelHata : Exception
    {
        public OzelHata()
        {
            Console.WriteLine("Negatif bir sayı girdiniz");
        }






    }
}
