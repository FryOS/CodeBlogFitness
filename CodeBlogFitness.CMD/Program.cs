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
            if (userController.IsNewUser) {
                Console.WriteLine("Ведите пол");
                var gender = Console.ReadLine();
            }

            Console.WriteLine( userController.CurrentUser);
            Console.ReadLine();
        }
    }
}
