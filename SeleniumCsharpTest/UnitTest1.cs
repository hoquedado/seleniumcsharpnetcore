using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpTest
{
    public class Tests: DriverHelper
    {

        

        [SetUp]
        public void Setup()
        {
            Console.Write("Setup");
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            //unknown checkbox
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            var a = 1;
            var b = 2;

            Assert.Pass();
        }
    }
}