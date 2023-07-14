using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests.model
{
    public class AccountData
    {
        private string username;
        private string password;

        public AccountData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username  
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password // свойство
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }




    }
}
