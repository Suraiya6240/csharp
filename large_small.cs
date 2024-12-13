using System;

class Test
{
    public static void Main(string[] args)
    {
        
        int number1, number2 ;
        Console.Write("Enter a number1 : ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number2 : ");
        number2 = Convert.ToInt32(Console.ReadLine());

        if(number1 > number2)
        Console.WriteLine($"{number1} is large");
        else
        {
            Console.WriteLine($"{number2} is small");
        }
       
    }
    
}
