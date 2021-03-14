using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectWP.JULIEM.Tests
{
    public class RequestFormBaseTest
    {


        public IWebDriver chromeBrowser;

        [SetUp]

        public void Setup()

        {
            
            chromeBrowser = new ChromeDriver(@"D:\");
            chromeBrowser.Url = "http://qaauto.co.nz/request-a-quote-form/";
            chromeBrowser.FindElement(By.XPath("//input[@id='wpforms-locked-22-field_form_locker_password']")).SendKeys("Testing");
            chromeBrowser.FindElement(By.Id("wpforms-submit-locked-22")).Click();

        }

        [TearDown]

        public void Teardown()

        {
            chromeBrowser.Quit();
            
        }




    }
}