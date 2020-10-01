/*Ai de plătit chiria lunară. Dar cu fiecare zi de întârziere trebuie să plătești o penalitate.
Dacă ai întârziat:
- 1-10  zile - plătești o penalitate de 2% din chirie/zi întârzire
- 11-30 zile - plătești o penalitate de 5% din chirie/zi întârzire
- 31+ zile - plătești o penalitate de 10% din chirie/zi întârzire
Dacă știi chiria și numărul de zile de întârziere, scrie o aplicație consolă ce calculează suma totală de plată.
Exemplu:
Pentru datele de intrare:
100
3
La consolă se va afișa:
106 
 */


using System;

namespace Test2Pb2Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            double rent = (double)Convert.ToDouble(inputData);
           
            inputData = Console.ReadLine();
            double days = (double)Convert.ToDouble(inputData);

            double penalty1 = (rent * 2) / 100;
            double penalty2 = (rent * 5) / 100;
            double penalty3 = (rent * 10) / 100;

            if (days >= 1 && days <= 10)
            {
                double totalRent = rent + (penalty1 * days);
                Console.WriteLine(totalRent);
            }
            else if (days >= 11 && days <= 30)
            {
                double totalRent = rent + (penalty2 * days);
                Console.WriteLine(totalRent);
            }
            else if (days > 31)
            {
                double totalRent = rent + (penalty3 * days);
                Console.WriteLine(totalRent);
            }
            else if (days == 0) 
            {
                double totalRent = rent;
                Console.WriteLine(totalRent);
            }
            Console.Read();
        }
    }
}
