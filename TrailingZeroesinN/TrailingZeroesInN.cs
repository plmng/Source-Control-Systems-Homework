using System;
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000
class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int n;
        if (int.TryParse(Console.ReadLine().ToString(), out n))
        {
            int countZeroes=0;
            for (int i = 5; i <= n; i*=5)
            {
                countZeroes+= n/i;
            }
            Console.WriteLine(countZeroes);
        }
        else Console.WriteLine("entered data is not correct");
    }
}

