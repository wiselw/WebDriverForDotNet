using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Gallio.Framework;

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


            IWebElement element =driver.FindElement(By.Id("cname"));//单个对象定位


            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //if (wait.Until(d => { return driver.Url.Contains("ssssss"); }))
            //{
            //    //开始工作
            //}

            driver.Quit();
        }
        [Test]
        [Name("Navigate")]
        public void NavigateTest()
        {
            //
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.ctrip.com");//打开页面，记得加上http://
            driver.Manage().Window.Maximize();//浏览器最大化，其他浏览器通
            TestLog.WriteLine(driver.Title);//输出title
            TestLog.WriteLine(driver.Url);//输出url
            TestLog.WriteLine(driver.PageSource);//输出页面源码
            driver.Quit();

        }
    }
}
