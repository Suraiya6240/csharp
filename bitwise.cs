using System;

class Test
{
    public static void Main(string[] args)
    {
        //bitwise opertator
        int num1 = 15;
        int num2 =  12;
         int result;
         result = num1 & num2;
         Console.WriteLine($"{num1} & {num2} = {result}") ;   
         result = num1 | num2;
         Console.WriteLine($"{num1} | {num2} = {result}") ; 
          result = num1 ^ num2;
         Console.WriteLine($"{num1} ^ {num2} = {result}") ; 
        result = 5 >> 2;
         Console.WriteLine($"5 >> 2 = {result}") ; 
         result = 14 << 2;
         Console.WriteLine($"14 << 2 = {result}") ; 
           

    }
}
s