using System;
class Test
{
    public static void Main(string[] agrs)
    {
           //output formatting 
            int number1 = 10 ;
            int number2 =3 ;
            int result;
            result= number1 +number2;
            Console.WriteLine("Additon : " + result);
            
            result= number1 - number2;
                Console.WriteLine("Subtraction : " + result);
                result=number1 *number2;
                Console.WriteLine("Multiplication :" + result);
                result= number1 / number2;
                Console.WriteLine("Division : " + result);
                result = number1 % number2;
                Console.WriteLine("Modules : " + result);
                     //evabe output nile 10+3=13 asbe number kore ..
                    Console.WriteLine($"{number1} + {number2} = {result}"); 
                    Console.WriteLine($"{number1} - {number2} = {result}");
                    Console.WriteLine($"{number1} * {number2} = {result}");
                    Console.WriteLine($"{number1} / {number2} = {result}");
                    Console.WriteLine($"{number1} %{number2} = {result}");
        }
}