using CodeBlogFitness.BL.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.CMD 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Фитнесс");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();


            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.WriteLine("Введите пол: ");
                var gender = Console.ReadLine();
                var birthDate = ParseDataTime();
                var weight = ParseDouble("вес");
                var height = ParseDouble("рост");
               
                userController.SetNewUserData(gender, birthDate, weight, height);
            }

            Console.WriteLine( userController.CurrentUser);
            Console.ReadLine();
        }

        private static DateTime ParseDataTime()
        {
            DateTime birthDate;
            while (true)
            {

                Console.WriteLine($"Введите дату рождения (dd.mm.yyyy) : ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;

                }
                else
                {
                    Console.WriteLine($"Неверный формат даты рождения");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name) 
        {
            while (true)
            {

                Console.WriteLine($"Введите {name} : ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                    
                }
                else {
                    Console.WriteLine($"Неверный формат {name}");
                }
            }
        }
    }
}
 