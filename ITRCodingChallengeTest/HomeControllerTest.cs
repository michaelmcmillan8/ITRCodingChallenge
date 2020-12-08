using ITRCodingChallenge.Controllers;
using ITRCodingChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace ITRCodingChallengeTest
{
    public class HomeControllerTest
    {
        // Asserts that the Index page of HomeController will return a view model containing a collection of 1-30 integers each in the range of 1-10000
        [Fact]
        public void Index_ReturnsNumberArray()
        {
            var controller = new HomeController();

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = viewResult.ViewData.Model as TableViewModel;

            Assert.NotNull(model);
            Assert.NotEmpty(model.TableNumbers);
            Assert.InRange(model.TableNumbers.Count, 1, 30);
            Assert.InRange(model.TableNumbers[0], 1, 10000);
        }
    }
}
