using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit;

namespace RunIt.Tests
{
    public class HomeControllerTest
    {

        [Fact]
        public void IndexReturnsAllRuns()
        {
            //// Arrange
            //var mockRepo = new Mock<IRunRepository>();
            //var mockLogger = new Mock<ILogger<HomeController>>();
            //var allRunsTest = new List<Run> {new Run(), new Run()};

            //mockRepo.Setup(repo => repo.GetAllRuns())
            //    .Returns(allRunsTest);

            //var sut = new HomeController(mockLogger.Object, mockRepo.Object);

            //// Act
            //var result = sut.Index();

            //// Assert
            //result.Should().BeOfType<ViewResult>();
            //result.Model.Should().BeOfType<HomeViewModel>()
            //    .Which.AllRuns.Should().BeEquivalentTo(allRunsTest);
        }

        //[Fact]
        //public void ReturnAllRuns()
        //{
        //    // Arrange
        //    var testRuns = new List<Run> { new Run(), new Run() };
        //    var mockLogger = new Mock<ILogger<HomeController>>();
        //    var sut = new HomeController(mockLogger.Object); 

        //    // Act 
        //    var result = sut.Index();

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var homeViewModel = Assert.IsType<HomeViewModel>(viewResult.Model);
        //    var allRuns = homeViewModel.Runs;

        //    allRuns.Should().BeEquivalentTo(testRuns);
        //}


    }
}
