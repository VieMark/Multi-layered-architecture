// DataAccessLayer/UserRepository.cs

using System.Collections.Generic;

namespace DataAccessLayer
{
    public class UserRepository
    {
        private List<string> users = new List<string>();

        public List<string> GetAllUsers()
        {
            return new List<string>(users);
        }

        public void AddUser(string name)
        {
            users.Add(name);
        }

        public void RemoveUser(string name)
        {
            users.Remove(name);
        }

        public bool UserExists(string name)
        {
            return users.Contains(name);
        }
    }
}