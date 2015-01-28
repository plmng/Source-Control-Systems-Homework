using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        try
        {
            Console.Write("enter binary number: ");
            string input = Console.ReadLine();
            long decRepresent = 0;
            int[] number = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                number[i] = int.Parse(input[i].ToString());
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != 0 && number[i] !=1)
                {
                    Console.WriteLine("entered data is not correct");
                    return;
                }
            }
            for (int i = 0, j=number.Length-1; i < number.Length; i++, j--)
            {
                decRepresent += number[i] * (long)Math.Pow(2,j);
            }
            Console.WriteLine(decRepresent);
        }
        catch (FormatException)
        {
           Console.WriteLine("entered data is not correct");
        }

    }
}
