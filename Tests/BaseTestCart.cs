﻿using Framework;
using Framework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class BaseTestCart
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Login.Open();
            Login.CloseCookiesWindow();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string methodName = TestContext.CurrentContext.Test.MethodName;
                string filePath = Driver.TakeScreenshot(methodName);
                TestContext.AddTestAttachment(filePath);
            }

            Driver.QuitDriver();
        }
    }
}