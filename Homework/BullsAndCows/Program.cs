using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());
            bool noNumber = true;

            for (int currentNumber = 1000; currentNumber <= 9999; currentNumber++)
            {
                int tempSecretNumber = secretNumber;
                int secretNumberD = tempSecretNumber % 10;
                tempSecretNumber = tempSecretNumber / 10;
                int secretNumberC = tempSecretNumber % 10;
                tempSecretNumber = tempSecretNumber / 10;
                int secretNumberB = tempSecretNumber % 10;
                tempSecretNumber = tempSecretNumber / 10;
                int secretNumberA = tempSecretNumber % 10;

                int tempCurrentNumber = currentNumber;
                int tempCurrentNumberD = tempCurrentNumber % 10;
                tempCurrentNumber = tempCurrentNumber / 10;
                int tempCurrentNumberC = tempCurrentNumber % 10;
                tempCurrentNumber = tempCurrentNumber / 10;
                int tempCurrentNumberB = tempCurrentNumber % 10;
                tempCurrentNumber = tempCurrentNumber / 10;
                int tempCurrentNumberA = tempCurrentNumber % 10;

                if (tempCurrentNumberA == 0 || tempCurrentNumberB == 0 || tempCurrentNumberC == 0 || tempCurrentNumberD == 0)
                {
                    continue;
                }

                int currentBulls = 0;
                int currentCows = 0;
                #region Find Bulls
                if (secretNumberA == tempCurrentNumberA)
                {
                    currentBulls++;
                    secretNumberA = -1;
                    tempCurrentNumberA = -2;
                }
                if (secretNumberB == tempCurrentNumberB)
                {
                    currentBulls++;
                    secretNumberB = -1;
                    tempCurrentNumberB = -2;
                }
                if (secretNumberC == tempCurrentNumberC)
                {
                    currentBulls++;
                    secretNumberC = -1;
                    tempCurrentNumberC = -2;
                }
                if (secretNumberD == tempCurrentNumberD)
                {
                    currentBulls++;
                    secretNumberD = -1;
                    tempCurrentNumberD = -2;
                }
                #endregion
                #region current Number A
                if (tempCurrentNumberA == secretNumberB)
                {
                    currentCows++;
                    tempCurrentNumberA = -2;
                    secretNumberB = -1;
                }
                if (tempCurrentNumberA == secretNumberC)
                {
                    currentCows++;
                    tempCurrentNumberA = -2;
                    secretNumberC = -1;
                }
                if (tempCurrentNumberA == secretNumberD)
                {
                    currentCows++;
                    tempCurrentNumberA = -2;
                    secretNumberD = -1;
                }
                #endregion
                #region current Number B
                if (tempCurrentNumberB == secretNumberA)
                {
                    currentCows++;
                    tempCurrentNumberB = -2;
                    secretNumberA = -1;
                }
                if (tempCurrentNumberB == secretNumberC)
                {
                    currentCows++;
                    tempCurrentNumberB = -2;
                    secretNumberC = -1;
                }
                if (tempCurrentNumberB == secretNumberD)
                {
                    currentCows++;
                    tempCurrentNumberB = -2;
                    secretNumberD = -1;
                }
                #endregion
                #region current Number C
                if (tempCurrentNumberC == secretNumberA)
                {
                    currentCows++;
                    tempCurrentNumberC = -2;
                    secretNumberA = -1;
                }
                if (tempCurrentNumberC == secretNumberB)
                {
                    currentCows++;
                    tempCurrentNumberC = -2;
                    secretNumberB = -1;
                }
                if (tempCurrentNumberC == secretNumberD)
                {
                    currentCows++;
                    tempCurrentNumberC = -2;
                    secretNumberD = -1;
                }
                #endregion
                #region current Number D
                if (tempCurrentNumberD == secretNumberA)
                {
                    currentCows++;
                    tempCurrentNumberD = -2;
                    secretNumberA = -1;
                }
                if (tempCurrentNumberD == secretNumberB)
                {
                    currentCows++;
                    tempCurrentNumberD = -2;
                    secretNumberB = -1;
                }
                if (tempCurrentNumberD == secretNumberC)
                {
                    currentCows++;
                    tempCurrentNumberD = -2;
                    secretNumberC = -1;
                }
                #endregion
                if (currentBulls == bulls && currentCows == cows)
                {
                    noNumber = false;
                    Console.Write("{0} ", currentNumber);
                }
            }
            if (noNumber == true)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
