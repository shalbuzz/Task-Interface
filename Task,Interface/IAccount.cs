using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Interface
{
    public interface IAccount
    {
        void ShowInfo();
        bool PasswordCheeker(string password);
    }
}
