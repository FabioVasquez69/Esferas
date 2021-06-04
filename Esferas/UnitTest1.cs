using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using System.Threading;
using SeleniumExtras.WaitHelpers;


namespace Esferas
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver driver;
        [TestMethod]
        public void BotonInhabilitado()
        {
            ChromeOptions options = new ChromeOptions;
            options.AddArgument("start-maximazed");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://demoqa.com/dynamic-properties");

            //driver.FindElement(By.XPath("//input[@id='enableAfter']")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            //wait.Until(ExpectedConditions.ElementIsVisible);

            IWebElement botonInvisible = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@id='visibleAfter']")));
            Console.WriteLine(botonInvisible.Text);

            IWebElement miOtroElemento -wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("")));
            miOtroElemento.Click();

        }

        public void Cerrar()
        {

            Thread.Sleep(6000);
            driver.Quit();
        }
    }

}
