using System;

class Test
{
    public static void Main(string[] args)
    {
        // assignment operators use
        int number1 = 20;
        number1 += 5;
        Console.WriteLine($"{number1}");

        number1 -= 5;
        Console.WriteLine($"{number1}");

        number1 *= 5;
        Console.WriteLine($"{number1}");
        number1 /= 5;
        Console.WriteLine($"{number1}");
        number1 %= 5;
        Console.WriteLine($"{number1}");
      
    }
}
