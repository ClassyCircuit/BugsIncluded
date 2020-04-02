using BugsIncluded.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using BugsIncluded.ViewModels;
using Moq;
using Microsoft.Extensions.Logging;
using BugsIncluded.Data.Repositories;

namespace BugsIncluded.Tests
{
    public class ControllerTests
    {
        private readonly HomeController homeController;

        public ControllerTests()
        {
            // arrange
            //var loggerMock = new Mock<ILogger<HomeController>>();
            //var postRepoMock = new Mock<PostRepository>();

            //homeController = new HomeController(loggerMock.Object, postRepoMock.Object);
        }
        [Fact]
        public async void IndexReturnsCardHolderViewModel()
        {
            //// act
            //var result = await homeController.Blog();

            //// assert
            //var viewModel = Assert.IsType<ViewResult>(result);
            //Assert.IsType<CardHolderViewModel>(viewModel.Model);
        }

        [Fact]
        public async void IndexCardViewModelsAreNotEmpty()
        {
            // act

        }
    }
}
