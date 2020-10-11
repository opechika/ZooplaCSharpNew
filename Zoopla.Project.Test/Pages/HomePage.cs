using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopla.Project.Test.Driver;

namespace Zoopla.Project.Test.Pages
{
    public class HomePage : BaseClass
    {
        private IWebElement acceptCookie;
        private IWebElement location;
        private IWebElement minPrice;
        private IWebElement searchButton;


        public void ClickOnAcceptCookies()
        {
            acceptCookie = GetElementByCssSelector(".ui-button-primary.ui-cookie-accept-all-medium-large");
            acceptCookie.Click();
        }

        public void EnterDestionation(string dest)
        {
            location = GetElementById("search-input-location");
            location.SendKeys(dest);
            location.Click();
        }

        public void SelectMinimumPrice(string miniPrice)
        {
            minPrice = GetElementByName("price_min");
            SelectByText(minPrice, miniPrice);
        }

        public SearchResultPage ClickOnSearchButton()
        {
            searchButton = GetElementById("search-submit");
            searchButton.Click();
            return new SearchResultPage();
        }
    }
}
