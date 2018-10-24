using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--disable-application-cache");

            IWebDriver driver = new ChromeDriver(@"D:\LEON\cromedriver", options);
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            var log = driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            var pass = driver.FindElement(By.XPath("//*[@id=\"pass\"]"));
            var submit = driver.FindElement(By.XPath("//*[@id=\"u_0_2\"]"));

            log.SendKeys("+380992825256");
            pass.SendKeys("1qaz2wsx3edc4rfv5tgb6yhn7ujm8ik,9ol.");
            submit.Click();

            //var send_modal = driver.FindElement(By.XPath("//div[1]/span[1]/a/span[1]"));
            //send_modal.Click();

            var send_text = driver.FindElement(By.Name("xhpc_message"));
            send_text.SendKeys("Hello");

            var send_photo = driver.FindElement(By.Name("composer_photo[]"));
            send_photo.SendKeys(@"C:\Users\s27-r1\Desktop\1524048711198316285.png");
            Thread.Sleep(10000);

            var submit_button = driver.FindElement(By.XPath("//div[2]/div[3]/div[2]/div/div/span/span/button"));

            submit_button.Click();

            Console.ReadLine();
            driver.Close();
        }
    }
}
