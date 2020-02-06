using BugsIncluded.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BugsIncluded.ViewModels;
using Moq;
using Microsoft.Extensions.Logging;

namespace BugsIncluded.Tests
{
    public class ControllerTests
    {
        private readonly HomeController homeController;

        public ControllerTests()
        {
            // arrange
            var mock = new Mock<ILogger<HomeController>>();
            homeController = new HomeController(mock.Object);
        }
        [Fact]
        public async void IndexReturnsCardViewModel()
        {
            // act
            var result = homeController.Index();

            // assert
            var viewModel = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<CardHolderViewModel>(viewModel.Model);
            
        }
    }
}
