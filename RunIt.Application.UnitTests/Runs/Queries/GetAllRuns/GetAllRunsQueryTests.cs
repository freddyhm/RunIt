using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Moq;
using RunIt.Application.Common.Interfaces;
using RunIt.Application.Runs.Queries.GetAllRuns;
using RunIt.Runs.Entities;
using Xunit;

namespace RunIt.Application.UnitTests.Runs.Queries.GetAllRuns
{
    public class GetAllRunsQueryTests
    {
        [Fact]
        public async Task ShouldReturnCorrectViewModelAndRunCount()
        {
            var mockRunData = new Mock<IRunData>();
            var mockMapper = new Mock<IMapper>();

            var count = 10;
            var listRun = 
            mockRunData.Setup(r => ((List<Run>)r.GetAll()).Count());

            var sut = new GetAllRunsQuery.GetAllRunsQueryHandler(mockRunData.Object, mockMapper.Object);
            var result = await sut.Handle(new GetAllRunsQuery(), CancellationToken.None);

            result.Should().BeOfType<AllRunsViewModel>();
            result.AllRuns.Count().Should().Be(count);
        }
    }
}
