using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Moq;
using RunIt.Application.Common.Interfaces;
using RunIt.Application.Runs.Queries.GetAllRuns;
using RunIt.Runs.Entities;
using RunIt.Web.Api.Library.Runs.Queries.GetAllRuns;
using Xunit;

namespace RunIt.Web.Api.Library.Tests.Runs.Queries.GetAllRuns
{
    public class GetAllRunsQueryTests
    {

        [Fact]
        public async Task WhenGetAllRunsQuery_ReturnAllRuns()
        {
            #region Arrange

            var mockRunData = new Mock<IRunData>();
            var mockMapper = new Mock<IMapper>();

            var testRunData = new List<Run>
            {
                new Run(),
                new Run()
            };

            var testRunDtoData = new List<RunDto>
            {
                new RunDto(),
                new RunDto()
            };

            mockRunData.Setup(r => r.GetAll()).Returns(testRunData);
            mockMapper.Setup(m => m.Map<IEnumerable<Run>, IEnumerable<RunDto>>(testRunData))
                .Returns(testRunDtoData);

            var sut = new GetAllRunsQuery.GetAllRunsQueryHandler(mockRunData.Object, mockMapper.Object);

            #endregion

            #region Act

            var result = await sut.Handle(new GetAllRunsQuery(), CancellationToken.None);

            #endregion

            #region Assert

            result.Should().BeOfType<AllRunsViewModel>();
            result.AllRuns.Count().Should().Be(testRunDtoData.Count);

            #endregion
        }
    }
}
