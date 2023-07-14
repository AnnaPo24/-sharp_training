using addressbook_web_tests.model;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {

        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }

        public void Login(AccountData account)  // добавили параметры,чтобы можно было выполнать лог ин с любым именем и паролем,вспомогательный метод (обобщённый)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}
