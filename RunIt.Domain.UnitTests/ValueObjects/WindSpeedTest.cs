using System;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Domain.UnitTests.ValueObjects
{
    public class WindSpeedTest
    {

        [Fact]
        public void ShouldReturnWindSpeedWhenSpeedGreaterThan0()
        {
            var speed = 15;
            var result = RunWindSpeed.Create(speed);
            var windSpeed = result.Value;  
           
            windSpeed.Value.Should().Be(speed);
        }

        [Fact]
        public void ShouldThrowInvalidOperationExceptionForNegativeWindSpeed()
        {
            var windSpeedOrError = RunWindSpeed.Create(-10);

            windSpeedOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Wind speed must be greater than 0");
        }

        [Fact]
        public void ShouldThrowInvalidOperationExceptionFor0WindSpeed()
        {
            var windSpeedOrError = RunWindSpeed.Create(0);

            windSpeedOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Wind speed must be greater than 0");
        }
    }
}
