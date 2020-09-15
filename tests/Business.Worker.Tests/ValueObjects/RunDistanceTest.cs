using System;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Business.Worker.Tests.ValueObjects
{
    public class RunDistanceTest
    {
        [Fact]
        
        public void WhenDistanceGreaterThan0_ReturnValidRunDistance()
        {
            #region Arrange

            const int distance = 10;

            #endregion

            #region Act

            var result = RunDistance.Create(distance);
            var runDistance = result.Value;

            #endregion

            #region Assert

            runDistance.Value.Should().Be(distance);

            #endregion
        }

        [Fact]
        public void GivenNegativeDistance_ThrowInvalidOperationException()
        {

            #region Arrange

            #endregion

            #region Act

            var distanceOrError = RunDistance.Create(-8.43);

            #endregion

            #region Assert

            distanceOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Distance must be greater than 0");

            #endregion
        }

        [Fact]
        public void GivenDistanceOf0_ThrowInvalidOperationException()
        {
            #region Arrange

            #endregion

            #region Act

            var distanceOrError = RunDistance.Create(0);

            #endregion

            #region Assert

            distanceOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Distance must be greater than 0");

            #endregion
        }
    }
}
