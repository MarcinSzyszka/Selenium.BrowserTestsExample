using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace Selenium.BrowserTestsExample.POM {
    public class SearchPage : WebBlock {
        public SearchPage(Session session) : base(session) {

        }

        public ITextField<SearchPage> SearchInput {
            get { return new TextField<SearchPage>(this, By.XPath(@"//*[@id=""lst-ib""]")); }
        }

        public IClickable<SearchPage> SearchButton {
            get { return new Clickable<SearchPage>(this, By.XPath(@"//*[@id=""tsf""]/div[2]/div[3]/center/input[1]")); }
        }

        public ITextField<ResultsPage> FirstResultAddress {
            get { return new ResultsPage(base.Session).FirstResultAddress; }
        }
    }
}
