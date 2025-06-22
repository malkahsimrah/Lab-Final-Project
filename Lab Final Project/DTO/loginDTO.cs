using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_Project.DTO
{
    public class loginDTO
    {
        private string role;
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public loginDTO(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public loginDTO()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
