using System;
class CalculateGCD
{
    static void Main()
    {
        try
        {
            Console.Write("enter value for number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter value for number b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            if (a > b)
            {
                a = b;
                b = c;
            }
            while (b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            Console.WriteLine(a);
        }
        catch (FormatException)
        {
            Console.WriteLine("Entered data is not correct");
        }
    }
}
