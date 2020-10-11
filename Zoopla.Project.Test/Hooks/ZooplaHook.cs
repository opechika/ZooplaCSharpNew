using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Zoopla.Project.Test.Driver;

namespace Zoopla.Project.Test.Hooks
{
    [Binding]
    public sealed class ZooplaHook : BaseClass
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("https://www.zoopla.co.uk/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
