using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {

        [Test]
        [Author("Dawid", "dpiegza7@gmail.com")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/campaign/landing.php?campaign_id=1555712102&extra_1=s%7Cc%7C294502781256%7Ce%7Cfacebook%20rejestracja%7C&placement=&creative=294502781256&keyword=facebook%20rejestracja&partner_id=googlesem&extra_2=campaignid%3D1555712102%26adgroupid%3D58698011923%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-332088086337%26loc_physical_ms%3D9067411%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMIoPb_qMfu-AIVcBoGAB1HfwB0EAAYASAAEgJX5fD_BwE";
                driver.Url = urlName;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='w']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\dpieg\source\repos\SeleniumCSharp\SeleniumCSharpTutorials\Screenshots\screen1.jpeg", ScreenshotImageFormat.Jpeg );
                Console.WriteLine(e.StackTrace);

                throw;
            }
            finally
            {
                if (driver!= null)
                {
                    driver.Quit();
                }
            }



        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/campaign/landing.php?campaign_id=1555712102&extra_1=s%7Cc%7C294502781256%7Ce%7Cfacebook%20rejestracja%7C&placement=&creative=294502781256&keyword=facebook%20rejestracja&partner_id=googlesem&extra_2=campaignid%3D1555712102%26adgroupid%3D58698011923%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-332088086337%26loc_physical_ms%3D9067411%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMIoPb_qMfu-AIVcBoGAB1HfwB0EAAYASAAEgJX5fD_BwE");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://gmail.com/");

            return list;
        }

        //[Test]
        //[Author("Dawid", "dpiegza7@gmail.com")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/campaign/landing.php?campaign_id=1555712102&extra_1=s%7Cc%7C294502781256%7Ce%7Cfacebook%20rejestracja%7C&placement=&creative=294502781256&keyword=facebook%20rejestracja&partner_id=googlesem&extra_2=campaignid%3D1555712102%26adgroupid%3D58698011923%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-332088086337%26loc_physical_ms%3D9067411%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMIoPb_qMfu-AIVcBoGAB1HfwB0EAAYASAAEgJX5fD_BwE";
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}

    }
}
