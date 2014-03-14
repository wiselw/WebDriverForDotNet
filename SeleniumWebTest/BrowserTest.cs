using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumWebTest
{
    [TestFixture]
    public class BrowserTest
    {
        

        [Test]
        [Name("启动IE浏览器")]
        public void StartIE()
        {
            //
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://www.ctrip.com");
            driver.Quit();
        }

        [Test]
        [Name("启动火狐浏览器")]
        public void StartFireFox()
        {
            //
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.ctrip.com");
            driver.Quit();
        }
        [Test]
        [Name("启动火狐浏览器")]
        public void StartChrome()
        {
            //
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.ctrip.com");
            driver.Manage().Window.Maximize();//浏览器最大化，其他浏览器通用
            //可以使用如下代码指定浏览器大小
            driver.Manage().Window.Size = new System.Drawing.Size(2000,2000);
            driver.Quit();
        }
    }
}
