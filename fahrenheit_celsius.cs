using System;

class Test
{
    public static void Main(string[] args)
    {
       
       double fahrenheit , celsius;

       Console.Write("Fahrenheit = ");
       fahrenheit = Convert.ToDouble(Console.ReadLine());
     celsius = (fahrenheit-32)/1.8;

    Console.WriteLine($"celsius={celsius.ToString ("F2")} degrees");
        
      
    }
}
