// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        
        [Test, Order(2),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/campaign/landing.php?campaign_id=1555712102&extra_1=s%7Cc%7C294502781256%7Ce%7Cfacebook%20rejestracja%7C&placement=&creative=294502781256&keyword=facebook%20rejestracja&partner_id=googlesem&extra_2=campaignid%3D1555712102%26adgroupid%3D58698011923%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-332088086337%26loc_physical_ms%3D9067411%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMIoPb_qMfu-AIVcBoGAB1HfwB0EAAYASAAEgJX5fD_BwE";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            Assert.Ignore("Defect");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/campaign/landing.php?campaign_id=1555712102&extra_1=s%7Cc%7C294502781256%7Ce%7Cfacebook%20rejestracja%7C&placement=&creative=294502781256&keyword=facebook%20rejestracja&partner_id=googlesem&extra_2=campaignid%3D1555712102%26adgroupid%3D58698011923%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-332088086337%26loc_physical_ms%3D9067411%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMIoPb_qMfu-AIVcBoGAB1HfwB0EAAYASAAEgJX5fD_BwE";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            Assert.Ignore("Defect");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/campaign/landing.php?campaign_id=1555712102&extra_1=s%7Cc%7C294502781256%7Ce%7Cfacebook%20rejestracja%7C&placement=&creative=294502781256&keyword=facebook%20rejestracja&partner_id=googlesem&extra_2=campaignid%3D1555712102%26adgroupid%3D58698011923%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-332088086337%26loc_physical_ms%3D9067411%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMIoPb_qMfu-AIVcBoGAB1HfwB0EAAYASAAEgJX5fD_BwE";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
