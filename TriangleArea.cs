using System;

class Test
{
    public static void Main(string[] args)
    {
       //triangle area =0.5 *base*height
       double baseleg ,height,triangleArea;
       Console.WriteLine("Triangle Area calculator");
       Console.WriteLine("Base = ");
       baseleg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Height = ");
       height = Convert.ToDouble(Console.ReadLine());
       triangleArea =0.5* baseleg* height;
       Console.WriteLine(triangleArea);
    }
}
