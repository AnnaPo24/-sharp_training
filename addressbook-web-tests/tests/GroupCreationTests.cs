
using addressbook_web_tests.model;

using NUnit.Framework;
using System.Text;



namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       
        [Test]
        public void GroupCreationTest()  // основной тестовый метод
        {
        
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";

            
            app.GroupHelper.Create(group);

        }

        [Test]
        public void EmptyGroupCreationTest()  // основной тестовый метод
        {
            
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

           
            app.GroupHelper.Create(group);
               
        }























    }
}
