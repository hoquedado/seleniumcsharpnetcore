using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpTest
{
    public class CustomControl : DriverHelper
    {
         

        public void ComboBox( string name, string value) {
             

            IWebElement combo = driver.FindElement(By.XPath($"//input[@id='{name}-awed']"));

            combo.Clear();
            combo.SendKeys("Almond");

            driver.FindElement(By.XPath($"//div[@id='{name}-dropmenu']//li[text()='Almond']")).Click();

        }
    }
}
