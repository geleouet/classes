using System;

namespace CodeTest
{

    ///
    /// This class generates prime numbers up to a user specified maximum.
    /// The algorithm used is the Sieve of Erastosthenes.
    ///
    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.runApp();
            Console.ReadKey();
        }
        static class AppHelper
        {
            public static void runApp()
            {
                const int M = 121;
                const int RR = 30;
                const int CC = 4;
                int ROFFSET;
                int C;
                bool JPRIME;
                int N;
                const int ORDMAX = 9;
                int[] MULT = new int[ORDMAX + 1];
                int J = 1;
                int K = 1;
                int ORD = 2;
                int SQUARE = 9;
                int[] P = new int[M + 1];
                P[1] = 2;
                while (K < M)
                {
                    do
                    {
                        J += 2;
                        if (J == SQUARE)
                        {
                            ORD = ORD + 1;
                            SQUARE = P[ORD] * P[ORD];
                            MULT[ORD - 1] = J;
                        }
                        N = 2;
                        JPRIME = true;
                        while (N < ORD && JPRIME)
                        {
                            while (MULT[N] < J)
                                MULT[N] += P[N] + P[N];
                            if (MULT[N] == J)
                                JPRIME = false;
                            N++;
                        }
                    } while (!JPRIME);
                    K++;
                    P[K] = J;
                }
                int PNBR = 1;
                int POFFSET = 1;
                while (POFFSET <= M)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("**** The First " + M + " Prime numbers # Page " + PNBR);
                    Console.WriteLine("----------------------------------------------------");
                    for (ROFFSET = POFFSET; ROFFSET < POFFSET + RR; ROFFSET++)
                    {
                        for (C = 0; C < CC; C++)
                            if (ROFFSET + C * RR <= M)
                                Console.Write(String.Format("{0,10}", P[ROFFSET + C * RR]));
                        Console.WriteLine("");
                    }
                    Console.WriteLine("\n");
                    PNBR += 1;
                    POFFSET += (RR * CC);
                }
            }
        }
    }
}

