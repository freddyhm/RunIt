using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using RunIt.Runs.ValueObjects;
using Xunit;

namespace RunIt.Tests
{
    public class WindSpeedTest
    {
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
