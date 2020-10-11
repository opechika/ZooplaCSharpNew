using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopla.Project.Test.Driver;

namespace Zoopla.Project.Test.Pages
{
    public class SearchResultPage : BaseClass
    {
        private IList<IWebElement> results;


        public void IsResultsDisplayed()
        {
            results = GetElementsByCssSelector(".listing-results-price.text-price");
            Assert.IsTrue(results.Count > 0);
        }
    }
}
