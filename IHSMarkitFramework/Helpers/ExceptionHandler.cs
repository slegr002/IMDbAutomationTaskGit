using NUnit.Framework;
using OpenQA.Selenium;
using System;
using res = IMDb.UI.TestFramework.Properties.Resources;

namespace IMDb.UI.TestFramework.Helpers
{
    class ExceptionHandler
    {
        public void CatchException(Exception ex)
        {
            if (ex == null)
            {
                throw new ArgumentNullException(nameof(ex), res.NullParm);
            }

            if (ex is NoSuchElementException)
            {
                Assert.Fail("Expected element does NOT exist. " + ex.ToString());
            }
            else if (ex is IndexOutOfRangeException)
            {
                Assert.Fail("Index number provided does not exist in list. " + ex.ToString());
            }
            else if (ex is ElementNotSelectableException)
            {
                Assert.Fail("Element is not selectable. " + ex.ToString());
            }
            else if (ex is ElementNotVisibleException)
            {
                Assert.Fail("Element is not visible. " + ex.ToString());
            }
            else if (ex is ElementNotInteractableException)
            {
                Assert.Fail("Element not interactable. " + ex.ToString());
            }
            else
            {
                Assert.Fail("Test failed with error: " + ex.ToString());
            }
        }
    }
}
