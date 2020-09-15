using System;
using AutoMapper;
using FluentAssertions;
using RunIt.Application.Mappings;
using RunIt.Runs.Entities;
using RunIt.Web.Api.Library.Runs.Queries.GetAllRuns;
using Xunit;

namespace RunIt.Web.Api.Library.Tests.Common.Mappings
{
    public class MappingTests
    {
        [Theory]
        [InlineData(typeof(Run), typeof(RunDto))]

        public void WhenMappingRunToRunDto_ReturnValidRunDto(Type source, Type destination)
        {
            #region Arrange

            var instance = Activator.CreateInstance(source);
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            var mapper = mapperConfiguration.CreateMapper();

            #endregion

            #region Act

            var result = mapper.Map(instance, source, destination);

            #endregion

            #region Assert

            result.Should().NotBeNull();
            result.Should().BeOfType<RunDto>();

            #endregion
        }
    }
}
