using System;

class Program
{
    public static void Main(string[] agrs)
    {
            string? studentName;
            int studentAge;
            double CGPA;
            bool reg;
            Console.Write("Enter your name: ");
            studentName=Console.ReadLine(); 

            Console.Write("Enter your age: ");
            studentAge= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your CGPA: ");
            CGPA= Convert.ToDouble(Console.ReadLine());

            Console.Write("have you already reg: ");
            reg=Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Name :"+ studentName);
            Console.WriteLine("Age: "+ studentAge +"year old");
            Console.WriteLine("CGPA :"+ CGPA);
            Console.WriteLine("registered: "+ reg);

    }
}