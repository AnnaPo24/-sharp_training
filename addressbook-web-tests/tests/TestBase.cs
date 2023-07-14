
using addressbook_web_tests.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicationManager app; // заменяем этой ссылкой все ссылки на хэлперов,кот были

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager(); //инициализируем аппменеджер

            app.NavigationHelper.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TearDownTest()
        {

            app.Stop(); //вызываем метод стоп из AppManager

        }

    }

}
