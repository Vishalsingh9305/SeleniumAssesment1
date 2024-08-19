using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumAssignment
{
    public class UnitTest1
    {
        IWebDriver driver;

        public UnitTest1()
        {
            driver = new ChromeDriver(@"C:\Users\HP\Downloads\chromedriver-win64");

            driver.Navigate().GoToUrl("http://www.facebook.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }
        [Fact]
        public void Test1()
        {
            IWebElement element1 = driver.FindElement(By.Id("email"));
            element1.SendKeys("vishal@gmail.com");
            Thread.Sleep(1000);
            IWebElement ele1 = driver.FindElement(By.Name("pass"));  
            ele1.SendKeys("Vishal231@");
            Thread.Sleep(1000);
            IWebElement ele2 = driver.FindElement(By.Name("login"));
            ele2.Click();
            Thread.Sleep(1000);
            driver.Close();
        }
    }
}