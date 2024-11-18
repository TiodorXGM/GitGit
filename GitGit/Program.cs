using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите в какую степень нужно возвести число:");
            int exp = Convert.ToInt32(Console.ReadLine());

            int result = program.Power(number, exp);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();


        }

        int Power(int number, int exponent)
        {
            return (int)Math.Pow(number, exponent); 
        }
    }
}

