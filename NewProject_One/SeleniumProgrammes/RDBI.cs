using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewProject_One.SeleniumProgrammes
{
    public class RDBI
    {
        // Radio button , Dropdown, Buttons, Inout box
        [Test]
        public void L1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            IWebElement CreateAccount = driver.FindElement(By.XPath("//*[text()='Create new account']"));
            Thread.Sleep(5000);
            CreateAccount.Click();

            Thread.Sleep(4000);
            IWebElement name = driver.FindElement(By.XPath("//*[@name='firstname']"));
            name.SendKeys("shilpa");

            Thread.Sleep(4000);
            //IWebElement ele1 = driver.FindElement(By.XPath("//*[@name='sex' and @value='1']"));
            //IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            //js1.ExecuteScript("arguments[0].click();", ele1);

            driver.FindElement(By.XPath("//*[@name='sex'and @value='1']")).Click();
            driver.FindElement(By.XPath("//*[@name='sex'and @value='2']")).Click();

            name.Clear();

            //Dropdowns
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@name='birthday_day']"));
            SelectElement e1 = new SelectElement(dropdown);
            Thread.Sleep(2000);
            e1.SelectByIndex(8);
            Thread.Sleep(2000);
            e1.SelectByValue("20");
            Thread.Sleep(2000);
            e1.SelectByText("1");
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Navigate().Forward();
            Thread.Sleep(3000);

            //Scroll Bar Method 1 using action class
            IWebElement chooseFile = driver.FindElement(By.Id("uploadPicture"));
            Actions ac = new Actions(driver);
            ac.MoveToElement(chooseFile).Perform();

            //Scroll Bar Method 2 using action Java script
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(false);", chooseFile);

            //driver.FindElement(By.XPath("//*[@id='hobbies-checkbox-2']")).Click();
            Thread.Sleep(3000);
            driver.Quit();

    }

        [Test]
        public void Scroll()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();                                        // Maximizing window
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Thread.Sleep(4000);
            IWebElement ele = driver.FindElement(By.XPath("//*[text()='Book Store Application']"));
            Actions ac = new Actions(driver);
            ac.MoveToElement(ele).Perform();
            Thread.Sleep(4000);
            IWebElement ele1 = driver.FindElement(By.XPath("//*[@id='hobbies-checkbox-2']"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", ele1);                       // To click element
            js.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight)");   // To scroll up
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");    // To scroll down
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@for='hobbies-checkbox-3']")).Click();
            driver.FindElement(By.XPath("//*[@for='hobbies-checkbox-3']")).Click();
            Thread.Sleep(3000);
        }

        [Test]
        public void Alerts()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();                                        // Maximizing window
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");
            Thread.Sleep(4000);
            IWebElement Button1 = driver.FindElement(By.XPath("//*[@id='content']//div//ul//li[1]//button"));
            Button1.Click();
            driver.SwitchTo().Alert().Accept();
            //Assertions


            IWebElement result = driver.FindElement(By.XPath("//*[text()='Result:']//following-sibling::*"));
            string actual = result.Text;
            string expected = "You successfully clicked an alert";


            Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.Equals(expected));
            Assert.IsTrue(actual.Contains("successfully"));


            IWebElement Button2 = driver.FindElement(By.XPath("//*[@id='content']//div//ul//li[2]//button"));
            Button2.Click();
            driver.SwitchTo().Alert().Dismiss();


            IWebElement Button3 = driver.FindElement(By.XPath("//*[@id='content']//div//ul//li[3]//button"));
            Button3.Click();
            driver.SwitchTo().Alert().SendKeys("Ravi");
        }

    }
}
