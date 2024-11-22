using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Interface
{
    public class User : IAccount
    {
        private static int _counter = 1;
        private string _password;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get => _password; set {
                if (!PasswordCheeker(value ))
                {
                    Console.WriteLine("Wrong doesnt meet requirement");
                    return;
                }
                _password = value;
            
            } }

        public User( string fullName, string email, string password)
        {
            Id = _counter++;

            this.FullName = fullName;
            this.Email = email;
            this.Password = password;
        }
        public bool PasswordCheeker(string password)
        {
            if(password.Length < 8) return false;
            bool hasUpper = false;
            bool hasDigit = false;
            bool hasLower = false;
            foreach (char c in password) { 
            
            if(char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (char.IsUpper(c)) { 
                 hasUpper = true;
                }

                if (char.IsLower(c)) {
                 hasLower = true;
                
                }
            }
            return hasUpper && hasDigit && hasLower;    
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id},{FullName},{Email},{Password}");
        }
    }
}
