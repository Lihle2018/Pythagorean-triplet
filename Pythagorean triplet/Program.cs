using System;

class PythagoreanTriplet
{
    //Explanation:
    //The program uses two nested for loops to iterate over all possible values of a and b.The value of c is then calculated as c = 1000 - a - b.
   // If a^2 + b^2 = c^2, then the program prints the values of a, b, and c and the product of abc, and exits using the return statement.
   //The first for loop iterates over all possible values of a, from 1 to 999, since a + b + c = 1000 and a < b < c.
   //The second for loop iterates over all possible values of b, from a + 1 to 999, since a < b < c and b > a.
  //When a Pythagorean triplet is found, the program prints the values of a, b, and c, as well as their product, and exits the loop using the return statement.
    static void Main()
    {
        int a, b, c;
        for (a = 1; a < 1000; a++)
        {
            for (b = a + 1; b < 1000; b++)
            {
                c = 1000 - a - b;
                if (a * a + b * b == c * c)
                {
                    Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
                    Console.WriteLine("Product of abc = {0}", a * b * c);
                    return;
                }
            }
        }
    }
}
