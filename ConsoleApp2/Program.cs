using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string user, pass = random.Next(100, 1000).ToString();
            int i = 10;
            do
            {
                Console.WriteLine("Введите пароль");
                user = Console.ReadLine();
                if (int.Parse(pass) > int.Parse(user))
                    Console.WriteLine("больше");
                else if (int.Parse(pass) < int.Parse(user))
                    Console.WriteLine("меньше");
                i--;
                if (i == 0)
                {
                    Console.WriteLine("Не Получилось, не фартонуло :)");
                    Environment.Exit(0);
                }
            }
            while (user != pass);
            Console.WriteLine("вы угадали пароль");
        }
    }
}
