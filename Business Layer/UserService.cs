// BusinessLayer/UserService.cs

using DataAccessLayer;
using System;

namespace BusinessLayer
{
    public class UserService
    {
        private UserRepository userRepository = new UserRepository();

        public bool CreateUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Имя не должно быть пустым.");
                return false;
            }

            if (userRepository.UserExists(name))
            {
                Console.WriteLine("Пользователь с таким именем уже существует.");
                return false;
            }

            userRepository.AddUser(name);
            return true;
        }

        public bool DeleteUser(string name)
        {
            if (!userRepository.UserExists(name))
            {
                Console.WriteLine("Пользователь не найден.");
                return false;
            }

            userRepository.RemoveUser(name);
            return true;
        }

        public void DisplayUsers()
        {
            var users = userRepository.GetAllUsers();
            if (users.Count == 0)
            {
                Console.WriteLine("Список пользователей пуст.");
            }
            else
            {
                Console.WriteLine("Список пользователей:");
                foreach (var user in users)
                {
                    Console.WriteLine($"- {user}");
                }
            }
        }
    }
}