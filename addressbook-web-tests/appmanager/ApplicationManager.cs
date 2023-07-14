
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver; // внутреннее, но наследники к нему имеют доступ
        protected string baseURL;

        protected LoginHelper loginHelper;  //ссылка на помошника
        protected NavigationHelper navigationHelper; 
        protected GroupHelper groupHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook";

            loginHelper = new LoginHelper(this); // добавили код,кот будет создавать помошников инициализировать
            navigationHelper = new NavigationHelper(this, baseURL); // инициализируем
            groupHelper = new GroupHelper(this); // инициализируем
        }

        public IWebDriver? Driver 
        {
            get 
            { 
                return driver;
            }
               
        }
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        public LoginHelper Auth
        {
            get 
            {
                return loginHelper; 
            }

        }

        public NavigationHelper NavigationHelper
        {
            get
            {
                return navigationHelper;
            }
        }

        public GroupHelper GroupHelper
        {
            get
            {
                return groupHelper;
            }
        }

       
    }
}
