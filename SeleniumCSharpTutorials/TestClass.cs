// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropDownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1);
            element.SelectByValue("6");
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }

    }
}
