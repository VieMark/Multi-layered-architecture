using BusinessLayer;
using System;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Показать пользователей");
                Console.WriteLine("2. Добавить пользователя");
                Console.WriteLine("3. Удалить пользователя");
                Console.WriteLine("4. Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userService.DisplayUsers();
                        break;
                    case "2":
                        Console.Write("Введите имя нового пользователя: ");
                        string newName = Console.ReadLine();
                        userService.CreateUser(newName);
                        break;
                    case "3":
                        Console.Write("Введите имя пользователя для удаления: ");
                        string nameToDelete = Console.ReadLine();
                        userService.DeleteUser(nameToDelete);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}