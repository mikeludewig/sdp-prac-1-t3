using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Solution for Problem 3, g18d5811
            long n = 600851475143; // inicilalizing the variable int64 bit given 
            long num = 0; // also the factor to be equal to 0

            for (long i = 2; i < n; i++) // the for loop to throught the number starting with the prime number 2 
            {
                if (n % i == 0) // if the number is divisble by itself 
                {

                    bool primeNum = true; // the number is prime 

                    for (long j = 2; j < i; j++) // is goes again in the loop to find the largest number 
                    {
                        if (i % j == 0) // if the numbers are the same 
                        {
                            primeNum = false; // is not a prime number 
                            break; // leaves the loop 
                        }
                    }
                    if (primeNum) // if the number is prime 
                    {
                        num = i; // the number is the largest prime number 

                    }
                    Console.WriteLine(num); // prints the number 
                    Console.ReadLine();// breaks a line 

                }
            }
    }
}
