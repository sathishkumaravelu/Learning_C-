using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDay3
{
    class RedBus
    {
        static void Main_(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-notifications","true"); 


            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.Url = "https://www.redbus.in/";

            IWebElement signinEle = driver.FindElement(By.Id("i-icon-profile"));
            signinEle.Click();

            driver.FindElement(By.Id("signInLink")).Click();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("9182377123");
            driver.FindElement(By.XPath("//span[text()='GENERATE OTP ']")).Click();

        }
    }
}
