using System;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Business.Worker.Tests.ValueObjects
{
    public class WindSpeedTest
    {

        [Fact]
        public void GivenSpeedGreaterThan0_ReturnValidWindSpeed()
        {
            #region Arrange

            var speed = 15;

            #endregion

            #region Act

            var result = RunWindSpeed.Create(speed);
            var windSpeed = result.Value;

            #endregion

            #region Assert

            windSpeed.Value.Should().Be(speed);

            #endregion
        }

        [Fact]
        public void GivenNegativeWindSpeed_ThrowInvalidOperationException()
        {
            #region Arrange

            var speed = -10;

            #endregion

            #region Act

            var windSpeedOrError = RunWindSpeed.Create(speed);

            #endregion

            #region Assert

            windSpeedOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Wind speed must be greater than 0");

            #endregion
        }

        [Fact]
        public void Given0WindSpeed_ThrowInvalidOperationException()
        {
            #region Arrange

            var speed = 0;

            #endregion

            #region Act

            var windSpeedOrError = RunWindSpeed.Create(speed);

            #endregion

            #region Assert

            windSpeedOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Wind speed must be greater than 0");

            #endregion
        }
    }
}
