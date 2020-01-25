using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadeTeste
{
    class NunitClassTestSelenium
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\chrome");
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
