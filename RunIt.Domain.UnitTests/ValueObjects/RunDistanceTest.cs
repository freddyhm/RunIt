using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Tests
{
    public class RunDistanceTest
    {
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
