using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectWP.JULIEM.Models;

namespace TestProjectWP.JULIEM.Pages
{
    public class RequestQuoteFormPage 
    {
        readonly IWebDriver _browser;

        public RequestQuoteFormPage()
        {
        }

        public RequestQuoteFormPage(IWebDriver chromeBrowser)
        {
            this._browser = chromeBrowser;
        }


        public IWebElement FirstNameTxtbox => _browser.FindElement(By.Id("wpforms-22-field_0"));
        public IWebElement LastNameTxtbox => _browser.FindElement(By.Id("wpforms-22-field_0-last"));
        public IWebElement BusinessNameTxtbox => _browser.FindElement(By.Id("wpforms-22-field_1"));
        public IWebElement EmailTxtbox => _browser.FindElement(By.Id("wpforms-22-field_2"));
        public IWebElement PhoneTxtbox => _browser.FindElement(By.Id("wpforms-22-field_3"));
        public IWebElement RequestTxtbox => _browser.FindElement(By.Id("wpforms-22-field_4"));
        public IWebElement SubmitButton => _browser.FindElement(By.Id("wpforms-submit-22"));


        public void FillandSubmitForm(string firstname, string lastname, string businessname, string email, string phone, string request)

        {
            FirstNameTxtbox.SendKeys(firstname);
            LastNameTxtbox.SendKeys(lastname);
            BusinessNameTxtbox.SendKeys(businessname);
            EmailTxtbox.SendKeys(email);
            PhoneTxtbox.SendKeys(phone);
            RequestTxtbox.SendKeys(request);
            SubmitButton.Click();

        }

        public void FillandSubmitForm(RequestBlankFormModel data)
        {
            FirstNameTxtbox.SendKeys(data.FirstName);
            LastNameTxtbox.SendKeys(data.LastName);
            BusinessNameTxtbox.SendKeys(data.BusinessName);
            EmailTxtbox.SendKeys(data.EmailAdd);
            PhoneTxtbox.SendKeys(data.PhoneNum);
            RequestTxtbox.SendKeys(data.RequestMsg);
            SubmitButton.Click();

        }
    }
}
