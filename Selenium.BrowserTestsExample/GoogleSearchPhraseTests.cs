using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Selenium.BrowserTestsExample {
    public class GoogleSearchPhraseTests {
        IWebDriver driver;
        public GoogleSearchPhraseTests() {
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
