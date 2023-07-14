using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using addressbook_web_tests.model;
using NUnit.Framework;

namespace WebAddressbookTests.tests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()  // основной тестовый метод
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "ttt";
            newData.Footer = "qqq";

            app.GroupHelper.Modify(1, newData); // 1 -группа в кот вносим значения и новые данные
        }
    }
}
