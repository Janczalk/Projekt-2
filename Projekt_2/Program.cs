using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Net;
using System.Diagnostics;

namespace Projekt_2
{
    class Program
    {
        static BigInteger licznik = 0;
        static BigInteger[] LiczbyPierwsze = { 100913, 1009139, 10091401, 1009140611, 10091406133, 100914061337, 1009140613399 };

        static bool InstPierwszePrzyzwoity(BigInteger n)
        {
            licznik = 1;
            if (n < 2)
                return false;
            else if (n < 4)
                return true;
            else if (n % 2 == 0)
                return false;
            else
            {
                for (BigInteger i = 3; i * i < n; i += 2)
                {
                    licznik++;
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }

        static bool InstPierwszePrzykladowy(BigInteger n)
        {
            licznik = 1;
            if (n < 2)
                return false;
            else if (n < 4)
                return true;
            else if (n % 2 == 0)
                return false;
            else
            {
                for (BigInteger i = 3; i < n/2; i+=2)
                {
                    licznik++;
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }

        static bool PierwszePrzyzwoity(BigInteger n)
        {
            if (n < 2)
                return false;
            else if (n < 4)
                return true;
            else if (n % 2 == 0)
                return false;
            else
            {
                for (BigInteger i = 3; i * i < n; i += 2)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }

        static bool PierwszePrzykladowy(BigInteger n)
        {
            if (n < 2)
                return false;
            else if (n < 4)
                return true;
            else if (n % 2 == 0)
                return false;
            else
            {
                for (BigInteger i = 3; i < n / 2; i += 2)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }

        static void CzasPrzykladowy()
        {
           BigInteger[] LiczbyPierwsze = new BigInteger[] { 100913, 1009139, 10091401, 1009140611, 10091406133, 100914061337, 1009140613399 };
           Stopwatch stoperek = new Stopwatch();
           stoperek.Reset();
           stoperek.Start();
           for (int i = 0; i < LiczbyPierwsze.Length; i++)
           {
               Console.WriteLine($"{LiczbyPierwsze[i]}; {PierwszePrzykladowy(LiczbyPierwsze[i])}; {stoperek.ElapsedTicks}");
           }
           stoperek.Stop();
        }

        static void CzasInstPrzykladowy()
        {
            BigInteger[] LiczbyPierwsze = new BigInteger[] { 100913, 1009139, 10091401, 1009140611, 10091406133, 100914061337, 1009140613399 };
            Stopwatch stoperek = new Stopwatch();
            stoperek.Reset();
            stoperek.Start();
            for (int i = 0; i < LiczbyPierwsze.Length; i++)
            {
                Console.WriteLine($"{LiczbyPierwsze[i]}; {InstPierwszePrzykladowy(LiczbyPierwsze[i])}; {licznik}; {stoperek.ElapsedTicks}");
            }
            stoperek.Stop();
        }


        static void CzasPrzyzwoity()
        {
            BigInteger[] LiczbyPierwsze = new BigInteger[] { 100913, 1009139, 10091401, 1009140611, 10091406133, 100914061337, 1009140613399 };
            Stopwatch stoperek = new Stopwatch();
            stoperek.Reset();
            stoperek.Start();
            for (int i = 0; i < LiczbyPierwsze.Length; i++)
            {
                Console.WriteLine($"{LiczbyPierwsze[i]}; {PierwszePrzyzwoity(LiczbyPierwsze[i])}; {stoperek.ElapsedTicks}");
            }
            stoperek.Stop();
        }

        static void CzasInstPrzyzwoity()
        {
            BigInteger[] LiczbyPierwsze = new BigInteger[] { 100913, 1009139, 10091401, 1009140611, 10091406133, 100914061337, 1009140613399 };
            Stopwatch stoperek = new Stopwatch();
            stoperek.Reset();
            stoperek.Start();
            for (int i = 0; i < LiczbyPierwsze.Length; i++)
            {
                Console.WriteLine($"{LiczbyPierwsze[i]}; {InstPierwszePrzyzwoity(LiczbyPierwsze[i])}; {licznik}; {stoperek.ElapsedTicks}");
            }
            stoperek.Stop();
        }

        static void Main(string[] args)
        {
            CzasInstPrzykladowy();
            Console.WriteLine("koniec");
        }
    }
}
