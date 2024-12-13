using System;

class Test
{
    public static void Main(string[] args)
    {
      int num1,num2,num3;
      Console.Write("num1 = ");
      num1= Convert.ToInt32( Console.ReadLine() ); 
        Console.Write("num2 = ");
      num2= Convert.ToInt32( Console.ReadLine() ); 
      Console.Write("num3 = ");
      num3= Convert.ToInt32( Console.ReadLine() ); 
      if(num1>num2 && num1>num3)
      {
        Console.WriteLine($"Largest number : {num1}");
      }
       else if(num2>num1 && num2>num3)
      {
        Console.WriteLine($"Largest number : {num2}");
      }
      else if(num3>num1 && num3>num2)
      {
        Console.WriteLine($"Largest number : {num3}");

      }
      else
      {
      Console.WriteLine($"all the numbers are equal");
      }
      
    }
    
}
