﻿namespace Framework.Pages
{
    public class Home
    {
        public class TopMenu
        {
            public static void ClickElParduotuve()
            {
                string locator = "//*[@id='menu-item-42212']";
                Common.ClickElement(locator);
            }

            public static void ClickDovanuKuponai()
            {
                string locator = "//*[@id='menu-item-74300']";
                Common.ClickElement(locator);

                string locatorBody = "/html/body[@style='']";
                Common.WaitForElementToBeVisible(locatorBody);
            }
        }

        public static void Open()
        {
            Driver.OpenPage("https://ornamentai.lt/");
        }

        public static void CloseCookiesWindow()
        {
            string locator = "//*[@id='cn-accept-cookie']";
            Common.WaitForElementAttributeToNotContainValue(locator, "class", "cn-animated");
            Common.ClickElement(locator);
        }

        public static void ClickUserIcon()
        {
            string locator = "//*[@id='masthead']//*[@class='icon-user']";
            Common.ClickElement(locator);
        }
    }
}
