using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace Selenium.BrowserTestsExample {
    public class Class1 {
        IWebDriver driver;
        public Class1() {
            driver = new ChromeDriver();
            driver.Url = @"https://www.google.pl/";
        }

        [Fact]
        public void Test() {
            //Arrange
            var searchElement = driver.FindElement(By.XPath(@"//*[@id=""lst-ib""]"));
            var searchButton = driver.FindElement(By.XPath(@"//*[@id=""tsf""]/div[2]/div[3]/center/input[1]"));

            //Act
            searchElement.SendKeys("Selenium");
            searchButton.Submit();
            var firstResultAddress = driver.FindElement(By.XPath(@"//*[@id=""rso""]/div[2]/div/div[1]/div/div/div/div/div[1]/cite"));

            //Assert
            Assert.Equal("www.seleniumhq.org/", firstResultAddress.Text);
            driver.Close();
        }
    }
}
