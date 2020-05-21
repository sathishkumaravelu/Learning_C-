using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDay3
{
    class PatienCreation
    {
        static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-notifications","true"); 


            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://demo.openemr.io/b/openemr/interface/login/login.php?site=default";


            IWebElement userNameEle = driver.FindElement(By.Id("authUser"));
            userNameEle.SendKeys("admin");


            //driver.FindElement(By.Id("email")).SendKeys("balaji017@gmail.com");

            IWebElement passwordEle = driver.FindElement(By.Id("clearPass"));
            passwordEle.SendKeys("pass");

            IWebElement languageEle = driver.FindElement(By.Name("languageChoice"));
            SelectElement dd = new SelectElement(languageEle);
            dd.SelectByText("English (Indian)");

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//div[text()='Patient/Client']")));


            
            Actions builder = new Actions(driver);

            builder.MoveToElement(driver.FindElement(By.XPath("//div[text()='Patient/Client']"))).Perform();

            driver.FindElement(By.XPath("//div[text()='Patients']")).Click();

            driver.SwitchTo().Frame("fin");

            driver.FindElement(By.Id("create_patient_btn1")).Click();

            driver.SwitchTo().DefaultContent();
            
            driver.SwitchTo().Frame("pat");

            driver.FindElement(By.Id("form_fname")).SendKeys("Corona");

            driver.FindElement(By.Id("form_lname")).SendKeys("China");

            driver.FindElement(By.Id("form_DOB")).SendKeys("2020-05-21");

            SelectElement sexDropDown = new SelectElement(driver.FindElement(By.Id("form_sex")));

            sexDropDown.SelectByText("Male");

            driver.FindElement(By.Id("create")).Click();

            driver.SwitchTo().DefaultContent();


            driver.SwitchTo().Frame("modalframe");
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            
        }
    }
}
