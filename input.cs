using System;

class Program
{
    public static void Main(string[] agrs)
    {
        string? studentName;
        int studentAge;
        Console.WriteLine("Enter your name: ");
        studentName=Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        studentAge= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name :"+ studentName);
        Console.WriteLine("Age: "+ studentAge);

    }
}