# PrimeNumbers Statistics


**_Easy_**

The aim of this exercice is to compute a surprising statistic of prime numbers.
Prime numbers are integer number having exactly 2 divisors : 1 and themselves.
All prime numbers greater or equal than 7, ends with the digit 1,3,7 ou 9.
(all even number are not prime since they are divisible by 2, and all number ending with 5 are divisible by 5).
We could expect that given a prime number the following prime number are distributed evenly between 1,3,7,9

_It appears that there are less prime number followed a prime number ending with the same digit._

Compute a table showing for each last digit, as a percentage (with 2 digits), the distribution of the following prime number, use the provided file for a set of prime numbers.


| From/ to | 1 | 3 | 7 | 9 |
|-|-|-|-|-|
| 1 | 17.15 | 31.00 | 31.79 | 20.07 |
| 3 | 23.29 | 15.86 | 29.12 | 31.73 |
| 7 | 25.69 | 27.44 | 15.84 | 31.03 |
| 9 | 33.85 | 25.75 | 23.26 | 17.14 |
-------------------------------------------

As you can see, for this computation done on the perimeter of the provided number,
the prime number whose last digit is 1, are more likely to be followed by a prime number ending with 7, then 3, then 9.. and finally 1.

> [list of primes number can be found here](https://github.com/geleouet/exercices/raw/master/primeStatistics/primes.txt)
