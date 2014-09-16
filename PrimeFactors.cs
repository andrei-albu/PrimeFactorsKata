using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    class PrimeFactors
    {
        private const int MaxSize = 2000;

        public static List<int> Generate(int number)
        {
            int count = 0;
            List<int> primesList = new List<int>(new int[MaxSize]);
            List<int> result = new List<int>(new int[MaxSize]);
            int index = 0;

            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                    primesList[count++] = i;
            }

            while (true)
            {
                if (IsPrime(number))
                {
                    result[index++] = number;
                    break;
                }

                for (int i = count - 1; i >= 0; i--)
                {
                    if ((number % primesList[i]) == 0)
                    {
                        result[index++] = primesList[i];
                        number = number / primesList[i];
                        break;
                    }
                }
            }
            return result;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}
