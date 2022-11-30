//Напишете програма, която извежда текущите дата и час.

using System.Diagnostics.CodeAnalysis;

namespace _08Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            System.Console.WriteLine(now);
        }
    }
}