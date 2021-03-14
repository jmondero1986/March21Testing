using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using TestProjectWP.JULIEM.Models;
using TestProjectWP.JULIEM.Pages;

namespace TestProjectWP.JULIEM.Tests
{
    public class RequestFormTest : RequestFormBaseTest

    {

        //[Test]
        //public void RequestForm()
        //{

        //    //Fill the request form

        //    RequestQuoteFormPage blankRequestForm = new RequestQuoteFormPage(chromeBrowser);
        //    blankRequestForm.FirstNameTxtbox.SendKeys("Julie00");
        //    blankRequestForm.LastNameTxtbox.SendKeys("Mondero00");
        //    blankRequestForm.BusinessNameTxtbox.SendKeys("Blah blah");
        //    blankRequestForm.EmailTxtbox.SendKeys("julie@blahblah.com");
        //    blankRequestForm.PhoneTxtbox.SendKeys("0212222255");
        //    blankRequestForm.RequestTxtbox.SendKeys("Message something something");


        //    //Validate the submit form
        //    blankRequestForm.SubmitButton.Click();
        //}



        //[TestCase("Julie", "Mondero", "MyBusiness", "julie@blah.com", "02124802214", "Message Request")]
        //[TestCase("Julie1", "Mondero", "MyBusiness1", "julie@blah.com", "02124802214", "Message Request")]
        //[TestCase("Julie2", "Mondero", "MyBusiness2", "julie@blah.com", "02124802214", "Message Request")]
        //[TestCase("Julie3", "Mondero", "MyBusiness3", "julie@blah.com", "02124802214", "Message Request")]
        //[TestCase("Julie4", "Mondero", "MyBusiness4", "julie@blah.com", "02124802214", "Message Request")]
        //[TestCase("Julie5", "Mondero", "MyBusiness5", "julie@blah.com", "02124802214", "Message Request")]

        //public void RequestForm(string firstname, string lastname, string businessname, string email, string phone, string request)


        //{

        //    //Fill the request form

        //    RequestQuoteFormPage blankRequestForm = new RequestQuoteFormPage(chromeBrowser);
        //    blankRequestForm.FillandSubmitForm(firstname, lastname, businessname, email, phone, request);

        //}

        //[Test]

        //public void RequestFormFromModel()


        //{

        //    RequestBlankFormModel data = new RequestBlankFormModel("JULIEmmm", "Mondero", "MyBusiness", "julie@blah.com", "02124802214", "Message Request Testing");

        //    //Fill the request form

        //    RequestQuoteFormPage blankRequestForm = new RequestQuoteFormPage(chromeBrowser);
        //    blankRequestForm.FillandSubmitForm(data);

        //}



        [TestCaseSource("TestDataNunit1")]

        public void RequestFormMultipleTesting(RequestBlankFormModel data)


        {
            //Fill the request form

            RequestQuoteFormPage blankRequestForm = new RequestQuoteFormPage(chromeBrowser);
            blankRequestForm.FillandSubmitForm(data);

        }

        //public static IEnumerable TestDataNunit

        //{
        //    get

        //    {

        //        yield return new TestCaseData(new RequestBlankFormModel("JULIE1", "MONDERO1", "MYBUSINESS1", "julie@blah.com", "02124802214", "Message Request Testing")).SetName("Test1");
        //        yield return new TestCaseData(new RequestBlankFormModel("JULIE2", "MONDERO2", "MYBUSINESS2", "julie@blah.com", "02124802214", "Message Request Testing")).SetName("Test2");


        //    }

        //}


        public static IEnumerable TestDataNunit1

        {
            get

            {
                for (int i=0; i<4; i++)
                {
                    yield return new TestCaseData(new RequestBlankFormModel("JULIE+" + i, "MONDERO1", "MYBUSINESS1", "julie@blah.com", "02124802214", "Message Request Testing")).SetName("Testing Case" + i);
                }

            }

        }


        [TestCaseSource("TestDataCSV")]

        public void TestMultipleRequestFormCSV(RequestBlankFormModel data)


        {
            //Fill the request form

            RequestQuoteFormPage blankRequestForm = new RequestQuoteFormPage(chromeBrowser);
            blankRequestForm.FillandSubmitForm(data);

        }

        public static IEnumerable TestDataCSV()

        {

            string filePath = "\\JULIEM\\DATA\\RequestFormCSV.csv";

            //READING THE CSV FILE
            using (var CSV= new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + filePath)),true))

            {
                while(CSV.ReadNextRecord())
                {
                    yield return new TestCaseData(new RequestBlankFormModel(CSV[0], CSV[1], CSV[2], CSV[3], CSV[4], CSV[5])).SetName(CSV[6]);


                }
            }

        }
    }
}
