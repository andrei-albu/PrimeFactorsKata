using System.Collections.Generic;

namespace PrimeFactorsKata
{
    class PrimeFactors
    {
        List<int> primesList = new List<int>();
        public List<int> Generate(int number)
        {
            List<int> result = new List<int>();

            FindPrimes(number);

            while (true)
            {
                if (IsPrime(number))
                {
                    result.Add(number);
                    break;
                }

                for (int i = 0; i < primesList.Count; i++)
                {
                    if ((number % primesList[i]) == 0)
                    {
                        result.Add(primesList[i]);
                        number = number / primesList[i];
                        break;
                    }
                }
            }
            return result;
        }

        private void FindPrimes(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                    primesList.Add(i);
            }

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
