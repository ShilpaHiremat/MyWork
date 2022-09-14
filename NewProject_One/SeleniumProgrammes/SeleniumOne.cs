using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewProject_One.SeleniumProgrammes
{
    public class SeleniumOne
    {
        [Test]
        public static void CaseOne()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("nav-link-accountList-nav-line-1")).Click();
            driver.FindElement(By.Id("ap_email")).SendKeys("shilpahiremaths@gmail.com");
            driver.FindElement(By.Id("continue")).Click();
            driver.FindElement(By.Id("ap_password")).SendKeys("Mylaptop@2022");
            driver.FindElement(By.Id("signInSubmit")).Click();

            IWebElement ele = driver.FindElement(By.Id("nav-logo-sprites"));
            var logoexits = ele.Displayed;
            Console.WriteLine("Logo Exists" + logoexits);

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Camera");
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            driver.FindElement(By.XPath("//img[@alt='Sony Alpha 7 II E-mount interchangeable lens mirrorless camera with full frame sensor']")).Click();
            IWebElement ele1 = driver.FindElement(By.XPath("//img[@alt='Sony Alpha 7 II E-mount interchangeable lens mirrorless camera with full frame sensor']"));
            var isdisplayed1 = ele1.Displayed;
            if(isdisplayed1)
            {
                Console.WriteLine("Camera found" + isdisplayed1);
                driver.FindElement(By.Id("add-to-cart-button")).Click();


            }
            else
            {
                Console.WriteLine("Camera not found" + isdisplayed1);
            }
            






        }
    }
}
