using System;

class Test
{
    public static void Main(string[] args)
    {
        //digit 0...9
        //digit .spelling program 
        //0 =zero 
        //1= one
        //12= not a valid digit
        Console.Write("Enter any digit between o and 9 : ");
        int digit = Convert.ToInt32(Console.ReadLine());//convert input dey ekta data store er jono 
       if(digit==0)
       {
        Console.WriteLine("zero");
       }
         else if(digit==1)
       {
        Console.WriteLine("One");
       }  
        else if(digit==2)
       {
        Console.WriteLine("Two");
       } 
        else if(digit==3)
       {
        Console.WriteLine("Three");
       }
       else if(digit==4)
       {
        Console.WriteLine("four");
       }
      else if(digit==5)
       {
        Console.WriteLine("Five");
       } 
      else if(digit==6)
       {
        Console.WriteLine("six");
       }   
      else if(digit==7)
       {
        Console.WriteLine("Seven");
       }
       else if(digit==8)
       {
        Console.WriteLine("Eight");
       }
       else if(digit==9)
       {
        Console.WriteLine("Nine");
       }
       else 
       {
        Console.WriteLine("Not a valid digit ");
       }
    }
    
}
