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



//go to webite

            chromeDriver.Navigate().GoToUrl("https://facebook.com");

            chromeDriver.FindElementByName("email").SendKeys("marcusgalvin@gmail.com");
            chromeDriver.FindElementByName("pass").SendKeys("bobjoebob1");
            chromeDriver.FindElementByClassName("login_form_login_button").Click();

            //go to profile

            chromeDriver.FindElementByClassName("_3ixn").Click();
            chromeDriver.FindElementById("home_birthdays").Click();

            chromeDriver.FindElementByClassName("enter_submit").SendKeys("happy birthday");

            //var friendsName = chromeDriver.FindElementByClassName("fsm")
            //Console.WriteLine(friendsName);





        }


    }
}