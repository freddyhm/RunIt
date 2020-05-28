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
    public class WaterSupplyTest
    {
        [Fact]
        public void ShouldThrowInvalidOperationExceptionForNegativeWaterSupply()
        {
            var waterSupplyOrError = WaterSupply.Create(-88);

            waterSupplyOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Water supply cannot be negative");
        }

        [Fact]
        public void ShouldNotThrowExceptionFor0WaterSupply()
        {
            var waterSupplyOrError = WaterSupply.Create(0);

            waterSupplyOrError.Invoking(x => x.Value)
                .Should()
                .NotThrow<InvalidOperationException>();
        }
    }
}
