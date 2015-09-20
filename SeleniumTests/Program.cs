using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = @"file:///C:\Users\n\Documents\visual studio 2015\Projects\SeleniumTests\SeleniumTests\TestPage.html";

            var table = driver.FindElement(By.TagName("table"));
            var innerTable = table.FindElement(By.TagName("table"));
            var row = innerTable.FindElements(By.TagName("td"))[1];
            Console.WriteLine(row.Text);





        }
    }
}
