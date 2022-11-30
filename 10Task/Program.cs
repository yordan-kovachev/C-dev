//Напишете програма, която извежда първите 100 члена на редицата 2,
//-3, 4, -5, 6, -7, 8
//COmplete this exercise when you reach chapter Loops

namespace _10Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
                else
                {
                    Console.WriteLine(-i + " ");
                }
            }
        }
    }
}