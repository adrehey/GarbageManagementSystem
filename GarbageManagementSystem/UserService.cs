using System.IO;
using System.Collections.Generic;

namespace GarbageManagementSystem
{
    public class UserService
    {
        private string filePath = "users.txt";

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            if (!File.Exists(filePath))
                return users;

            foreach (var line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(',');

                if (data.Length < 3) continue;

                users.Add(new User
                {
                    Username = data[0],
                    Password = data[1],
                    Role = data[2]
                });
            }

            return users;
        }

        public User ValidateLogin(string username, string password)
        {
            foreach (var user in GetAllUsers())
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public void RegisterUser(User user)
        {
            string line = $"{user.Username},{user.Password},{user.Role}";
            File.AppendAllText(filePath, line + "\n");
        }
    }
}