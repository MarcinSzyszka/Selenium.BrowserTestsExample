using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;
using OpenQA.Selenium;

namespace Selenium.BrowserTestsExample.POM {
    public class ResultsPage : WebBlock {
        public ResultsPage(Session session) : base(session) {
        }

        public ITextField<ResultsPage> FirstResultAddress {
            get { return new TextField<ResultsPage>(this, By.XPath(@"//*[@id=""rso""]/div[2]/div/div[1]/div/div/div/div/div[1]/cite")); }
        }
    }
}
