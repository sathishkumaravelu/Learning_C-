using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDay3
{
    class LearnFrames
    {
        static void Main_(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();


            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame("login_page");
            IWebElement userNameEle = driver.FindElement(By.XPath("//input[@name='fldLoginUserId']"));
            userNameEle.SendKeys("admin");


            driver.FindElement(By.XPath("(//img[@alt='continue'])[1]")).Click();

            driver.SwitchTo().DefaultContent();


        }
    }
}
