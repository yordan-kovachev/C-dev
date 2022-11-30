//Използвайте методите System.Console.ReadLine(), int.Parse() и
//System.DateTime.AddYears().

namespace _11Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;

            Console.WriteLine("Enter your name: ");

            // using the method
            // typecasting not needed
            // as ReadLine returns string
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");

            // Converted string to int
            age = Convert.ToInt32(Console.ReadLine());


            //Check age for the user
            //Allow voting if user is older than 18 years of age
            //Don't allow if user is bellow 18 years of age
            if (age >= 18)
            {
                Console.WriteLine("Hello " + name + "!"
                            + " You can vote");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!"
                    + " Sorry you can't vote");
            }
        }
    }
}