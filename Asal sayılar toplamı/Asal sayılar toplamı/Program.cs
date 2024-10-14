using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Asal_sayılar_toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.Write("Bir sayı girin (N): ");
            int N = int.Parse(Console.ReadLine());

            int sumOfPrimes = SumOfPrimes(N);

            Console.WriteLine($"\n1'den {N}'e kadar olan asal sayıların toplamı: {sumOfPrimes}");
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static int SumOfPrimes(int N)
        {
            int sum = 0;

            for (int i = 2; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }

            }

            return sum;
            #endregion
        }


        }
}
    


