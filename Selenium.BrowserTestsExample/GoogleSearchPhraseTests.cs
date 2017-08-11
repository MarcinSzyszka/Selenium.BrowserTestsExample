using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
using Selenium.BrowserTestsExample.POM;
using Xunit;

namespace Selenium.BrowserTestsExample {
    public class GoogleSearchPhraseTests {

        SearchPage searchPageUnderTest;

        public GoogleSearchPhraseTests() {
            searchPageUnderTest = Threaded<Session>
                                .With<Chrome>()
                                .NavigateTo<SearchPage>(@"https://www.google.pl/");
        }

        [Fact]
        public void Test() {
            //Act
            searchPageUnderTest.SearchInput.AppendText("Selenium");
            searchPageUnderTest.SearchButton.Tag.Submit();
            var firstResultAddress = searchPageUnderTest.FirstResultAddress.Tag.Text;

            //Assert
            Assert.Equal("www.seleniumhq.org/", firstResultAddress);

            Threaded<Session>
             .End();
        }
    }
}
