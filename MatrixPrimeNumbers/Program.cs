using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixPrimeNumbers
{
    class Program
    {
        static bool isPrime(int number)
        {
            double boundary = Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Queue<int> primes = new Queue<int>();
            int n = 100;
            int square = n * n;

            int[,] arr = new int[1000, 1000];

            for (int i = 2; i < int.MaxValue; i++)
            {
                if (isPrime(i))
                {
                    primes.Enqueue(i);
                    if (primes.Count == square) break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = primes.Dequeue();
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
