using System;

class Test
{
    public static void Main(string[] args)
    {
       
       double fahrenheit , celsius;

       Console.Write("Celsius = ");
       celsius = Convert.ToDouble(Console.ReadLine());
      fahrenheit = ((1.8*celsius)+32);

    Console.WriteLine($"fahrenheit={fahrenheit.ToString ("F2")} degrees");
        
      
    }
}
