using BugsIncluded.Controllers;
using System;
using Xunit;
using FluentAssertions.Extensions;

namespace BugsIncluded.Tests
{
    public class ControllerTests
    {
        private readonly HomeController homeController;

        public ControllerTests(HomeController homeController)
        {
            // arrange
            this.homeController = homeController;
        }
        [Fact]
        public async void IndexReturnsCardViewModel()
        {
            // act
            var result = homeController.Index();

            // assert
            var viewModel = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<CardViewModel>(viewModel.ViewData.Model);

        }
    }
}
