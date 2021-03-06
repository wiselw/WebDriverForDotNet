﻿using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.ObjectModel;

namespace SeleniumWebTest
{
    [TestFixture]
    public class LocateTest
    {
        private IWebDriver driver;
        [Test]
        public void ClassNameText()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("file:///D:/Github/WebDriverForDotNet/SeleniumWebTest/locate.html");
            driver.FindElement(By.Id("inputemail")).SendKeys("someone@163.com");
            //driver.FindElement(By.Id("inputname")).SendKeys("some");
            //输出 someone@163.com,不是some
           // TestLog.WriteLine(driver.FindElement(By.ClassName("intro")).GetAttribute("value"));
            //输出 someone@163.com
            //TestLog.WriteLine(driver.FindElement(By.CssSelector("#inputemail")).GetAttribute("value"));
            //driver.FindElement(By.PartialLinkText("度一")).Click();
            //driver.FindElement(By.LinkText("百度一下")).Click();
            //driver.FindElement(By.Name("email")).SendKeys("someone@163.com");
            //driver.FindElement(By.TagName("input")).SendKeys("TagName");
            //driver.FindElement(By.XPath("//input[@id='inputemail']")).SendKeys("大风");
            //ReadOnlyCollection<IWebElement> list = driver.FindElements(By.TagName("input"));
            //TestLog.WriteLine(list.Count);//输出2
            string a = driver.FindElement(By.Name("email")).GetAttribute("value");
            string b = driver.FindElement(By.Id("tbl"))
                .FindElement(By.Name("email")).Text;
            TestLog.WriteLine(a);//someone@163.com
            TestLog.WriteLine(b);//10001
            driver.Quit();
            
            
        }
        [Test]
        public void ElementOperateTest()
        {
            //
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();//浏览器最大化
            driver.Navigate().GoToUrl("file:///D:/Github/WebDriverForDotNet/SeleniumWebTest/locate.html");
            driver.FindElement(By.Id("inputemail")).SendKeys("someone@163.com");//为输入框输入数据
            //点击按钮“修改输入框”，将输入框内容由“我是默认值”改为“我是修改后的值”
            driver.FindElement(By.Id("cleartxt")).Click();
            //清空输入框内容，将输入框内容由“我是默认值”变为空：
            driver.FindElement(By.Id("cleartextdemo")).Clear();
            driver.Quit();

        }
        [Test]
        public void KeyInptTest()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();//浏览器最大化
            driver.Navigate().GoToUrl("file:///D:/Github/WebDriverForDotNet/SeleniumWebTest/locate.html");
            //driver.FindElement(By.Id("alert")).Click();
            //driver.FindElement(By.Id("alert")).SendKeys(Keys.Space);
            driver.FindElement(By.Id("ctrla")).SendKeys( Keys.NumberPad1);
            //driver.Quit();
        }
    }
}
