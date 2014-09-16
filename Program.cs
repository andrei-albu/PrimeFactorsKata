using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> resultList;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            resultList = PrimeFactors.Generate(n);
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] == 0)
                    break;
                Console.Write(resultList[i]);
                if (i != resultList.Count - 1)
                    Console.Write(" * ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
