# FizzBuzzWoof #

_Our startup The FizzBuzzWoof Factory really wants to make a difference with the old fashioned guys from the FizzBuzz Inc. So we are going to add the following features to our product._

We keep the original rules, so a number divisible by 3 is replaced with Fizz. But we go one step further: everytime a 3 is met in a number, we add Fizz to the replaced number. Here are some examples:

_1 => 1 (not divisible by 3, doesn't contains a 3)_

_2 => 2 (not divisible by 3, doesn't contains a 3)_

_6 => Fizz (divisible by 3)_

_3 => FizzFizz (divisible by 3, contains a 3)_

Then we do the same for 5 and Buzz. Here are some more examples:

_10 => Buzz (divisible by 5)_

_5 => BuzzBuzz (divisible by 5, contains a 5)_

And of course we support both at the same time:

_15 => FizzBuzzBuzz (divisible by 3, divisible by 5, contains a 5)_

_2535 => FizzBuzzBuzzFizzBuzz (divisible by 3, divisible by 5, contains a 5, then a 3, then a 5)_

And then to really make a difference on our market, we need to support the 7, replaced with Woof.

_17 => Woof (contains 7)_

_35 => BuzzWoofFizzBuzz (divisible by 5, divisible by 7, contains 3, contains 5)._

At last, a strategic requirement came from the market guys. We need to keep track of the 0 in the incoming numbers for a very important customer. Each 0 should be replaced by a star *. 
Here are some examples:

_10 => Buzz*_

_101 => 1*1_

_30 => FizzBuzzFizz*_

_3105 => FizzBuzzFizz*Buzz_
