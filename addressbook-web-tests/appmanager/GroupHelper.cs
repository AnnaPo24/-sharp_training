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
    public class GroupHelper : HelperBase
    {

        public GroupHelper(ApplicationManager manager) : base(manager) { }

        public GroupHelper Create(GroupData group) // высокоуровневый вспомогательный метод
        {
            manager.NavigationHelper.GoToGroupsPage(); // код перехода на нужную нам страницу

            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper Modify(int p, GroupData newData)
        {
            manager.NavigationHelper.GoToGroupsPage(); // код перехода на нужную нам страницу
            SelectGroup(p);
            InitGroupModification();
//            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();

            return this;
            
        }

        public GroupHelper Remove(int p) // высокоуровневый вспомогательный метод
        {
            manager.NavigationHelper.GoToGroupsPage();

//            SelectGroup(p); // будем всегда удалять первую группу в списке
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }

     
        public GroupHelper InitGroupCreation() // был void , сделали чтобы возвращал 
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name"))
                  .Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
//            driver.FindElement(By.XPath("//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification() // был void , сделали чтобы возвращал 
        {
            driver.FindElement(By.Name("update"))
                  .Click();
            return this;
        }
        public GroupHelper InitGroupModification() // был void , сделали чтобы возвращал 
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

    }
}
