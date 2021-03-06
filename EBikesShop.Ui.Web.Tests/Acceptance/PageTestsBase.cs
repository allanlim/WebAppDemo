using EBikesShop.Ui.Web.Automation.Runners;
using NUnit.Framework;

namespace EBikesShop.Ui.Web.Tests.Acceptance
{
    public class PageTestsBase
    {
        [OneTimeSetUp]
        public void OpenAppInBrowser()
        {
            ApplicationRunner.StartBrowser();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            ApplicationRunner.CloseBrowser();
        }
    }
}
