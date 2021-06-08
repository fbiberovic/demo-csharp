using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Core.BestPractices.Web.Tests
{
    [TestFixture]
    public class WebTestsBase : AllTestsBase
    {
        [TearDown]
        public void CleanUpAfterEveryTestMethod()
        {
            if (Driver == null)
                return;
            ExecuteSauceCleanupSteps(Driver);
            Driver.Quit();
        }
        [SetUp]
        public void Setup()
        {
            SauceOptions = new Dictionary<string, object>
            {
                ["username"] = SauceUserName,
                ["accessKey"] = SauceAccessKey,
                ["name"] = TestContext.CurrentContext.Test.Name
            };
        }
    }
}