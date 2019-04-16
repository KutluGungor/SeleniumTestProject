using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class Tests
    {


        private RemoteWebDriver driver;

        [SetUp]
        public void Setup()
        {
            string driverDirectory = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory))), "Driver");
            driver = new ChromeDriver(driverDirectory);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.n11.com");
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

        [Test]
        public void TestSiteTitle()
        {
            var title = driver.Title;

            Assert.IsTrue(title == "n11.com - Alışverişin Uğurlu");
        }
    }
}