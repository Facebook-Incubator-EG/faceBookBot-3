using System;
using OpenQA.Selenium.Chrome;

namespace happyBirthday
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver(options);



            chromeDriver.Navigate().GoToUrl("https://facebook.com");

            chromeDriver.FindElementByName("email").SendKeys("marcusgalvin@gmail.com");
            chromeDriver.FindElementByName("pass").SendKeys("**yourpassword");
            chromeDriver.FindElementByClassName("login_form_login_button").Click();

            //go to profile
            chromeDriver.FindElementByClassName("_2s25").Click();



        }


    }
}