using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Zoopla.Project.Test.Pages;

namespace Zoopla.Project.Test.StepDefinitions
{
    [Binding]
    public sealed class ForSaleSaerchSteps
    {
        HomePage homePage = new HomePage();
        SearchResultPage searchResultPage = new SearchResultPage();

        [Given(@"I navigate to zoopla homepage")]
        public void GivenINavigateToZooplaHomepage()
        {
            homePage.ClickOnAcceptCookies();
        }

        [When(@"I enter ""(.*)"" into the search field")]
        public void WhenIEnterIntoTheSearchField(string location)
        {
            homePage.EnterDestionation(location);
        }

        [When(@"I select ""(.*)"" from Min price dropdown")]
        public void WhenISelectFromMinPriceDropdown(string minPrice)
        {
            homePage.SelectMinimumPrice(minPrice);
        }

        [When(@"I select ""(.*)"" from Max price dropdown")]
        public void WhenISelectFromMaxPriceDropdown(string p0)
        {

        }

        [When(@"I select ""(.*)"" from Property type dropdown")]
        public void WhenISelectFromPropertyTypeDropdown(string p0)
        {

        }

        [When(@"I select ""(.*)"" from Bedrooms dropdown")]
        public void WhenISelectFromBedroomsDropdown(string p0)
        {

        }

        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            searchResultPage = homePage.ClickOnSearchButton();
        }

        [Then(@"search result page is displayed with relevant results")]
        public void ThenSearchResultPageIsDisplayedWithRelevantResults()
        {

        }

    }
}
