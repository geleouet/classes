class program:
    """
    ///
    /// This class generates prime numbers up to a user specified maximum.
    /// The algorithm used is the Sieve of Erastosthenes.
    ///
    """
    def __init__(self, *args):
        self.AppHelper()

    class AppHelper:
        def __init__(self):
            M = 121
            RR = 30
            CC = 4
            JPRIME = False
            ORDMAX = 9
            MULT = list(range(ORDMAX + 1))
            J = 1
            K = 1
            ORD = 2
            SQUARE = 9
            P = list(range(M+1))
            P[1] = 2

            while K < M:
                while True:
                    J += 2
                    if J == SQUARE:
                        ORD = ORD + 1
                        SQUARE = P[ORD] * P[ORD]
                        MULT[ORD - 1] = J
                    N=2
                    JPRIME = True
                    while (N < ORD) & JPRIME:
                        while MULT[N] < J:
                            MULT[N] += P[N] + P[N]
                        if (MULT[N] == J):
                            JPRIME = False
                        N+=1

                    if JPRIME:
                        break
                K+=1
                P[K] = J

            PNBR = 1
            POFFSET = 1
            while POFFSET <= M:
                print("----------------------------------------------------")
                print("**** The First " + str(M) + " Prime numbers # Page " + str(PNBR))
                print("----------------------------------------------------")
                ROFFSET = POFFSET
                while ROFFSET < POFFSET + RR:
                    C = 0
                    while C < CC:
                        if (ROFFSET + C*RR) <= M:
                            print('{:10}'.format(P[ROFFSET + C*RR]), end='')
                        C+=1
                    print("")
                    ROFFSET +=1
                print("\n")
                PNBR += 1
                POFFSET += RR*CC
