// -----------------------------------------------------------------------
// <copyright file="Prime.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DSA
{
    using System;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class PrimePrint
    {
        public static void PrintPrimeNumber1(int num)
        {
            Console.Write(2);
            int primeCount = 1;
            int iteCount = 0;
            bool isPrime;
            for (int i = 3; i <= num; i++)
            {
                isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    ++iteCount;
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    ++primeCount;
                    Console.Write("{0}\t", i);
                }
            }

            Console.WriteLine("\nCount: {0}", primeCount);
            Console.WriteLine("IterationCount: {0}\n", iteCount);
        }

        public static void PrintPrimeNumber2(int num)
        {
            Console.Write(2);
            int primeCount = 1;
            int iteCount = 0;
            bool isPrime;
            for (int i = 3; i <= num; i += 2)
            {
                isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    ++iteCount;
                    if ((i % j) == 0)
                    {
                        isPrime = false;                     
                        break;
                    }
                }

                if (isPrime == true)
                {
                    ++primeCount;
                    Console.Write("{0}\t", i);
                }
            }

            Console.WriteLine("\nCount: {0}", primeCount);
            Console.WriteLine("IterationCount: {0}\n", iteCount);
        }

        public static void PrintPrimeNumber3(int num)
        {
            Console.Write(2);
            int primeCount = 1;
            int iteCount = 0;
            bool isPrime;
            for (int i = 3; i <= num; i += 2)
            {
                isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    ++iteCount;
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    ++primeCount;
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine("\nCount: {0}", primeCount);
            Console.WriteLine("IterationCount: {0}\n", iteCount);
        }
        
        public static void PrintPrimeNumber4(int num)
        {
            Console.Write(2);
            int primeCount = 1;
            int iteCount = 0;
            bool isPrime;
            for (int i = 3; i <= num; i += 2)
            {
                isPrime = true;
                for (int j = 2; (j * j) <= i; j++)
                {
                    ++iteCount;
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    ++primeCount;
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine("\nCount: {0}", primeCount);
            Console.WriteLine("IterationCount: {0}\n", iteCount);
        }
    }
}
