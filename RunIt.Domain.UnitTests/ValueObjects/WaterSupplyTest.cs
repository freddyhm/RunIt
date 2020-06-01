using System;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Domain.UnitTests.ValueObjects
{
    public class WaterSupplyTest
    {
        [Fact]
        public void ShouldReturnWaterSupplyWhenQuantityGreaterThan0()
        {
            var qty = 4;
            var result = WaterSupply.Create(qty);
            var waterSupply = result.Value;

            waterSupply.Value.Should().Be(qty);
        }

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
