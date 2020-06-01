using System;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Domain.UnitTests.ValueObjects
{
    public class RunDistanceTest
    {
        [Fact]
        public void ShouldReturnRunDistanceWhenDistanceGreaterThan0()
        {
            const int distance = 10;
            var result = RunDistance.Create(distance);
            var runDistance = result.Value;

            runDistance.Value.Should().Be(distance);
        }

        [Fact]
        public void ShouldThrowInvalidOperationExceptionForNegativeDistance()
        {
            var distanceOrError = RunDistance.Create(-8.43);

            distanceOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Distance must be greater than 0");
        }

        [Fact]
        public void ShouldThrowInvalidOperationExceptionFor0Distance()
        {
            var distanceOrError = RunDistance.Create(0);

            distanceOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Distance must be greater than 0");
        }
    }
}
