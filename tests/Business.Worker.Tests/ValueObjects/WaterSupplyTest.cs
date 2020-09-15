using System;
using FluentAssertions;
using RunIt.Domain.ValueObjects;
using Xunit;

namespace RunIt.Business.Worker.Tests.ValueObjects
{
    public class WaterSupplyTest
    {
        [Fact]
        public void GivenWaterQuantityGreaterThan0_ReturnValidWaterSupply()
        {
            #region Arrange

            var qty = 4;

            #endregion

            #region Act

            var result = WaterSupply.Create(qty);
            var waterSupply = result.Value;

            #endregion

            #region Assert

            waterSupply.Value.Should().Be(qty);

            #endregion
        }

        [Fact]
        public void GivenNegativeWaterQuantity_ThrowInvalidOperationException()
        {
            #region Arrange

            var qty = -88;

            #endregion

            #region Act

            var waterSupplyOrError = WaterSupply.Create(qty);

            #endregion

            #region Assert

            waterSupplyOrError.Invoking(x => x.Value)
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("Water supply cannot be negative");

            #endregion
        }

        [Fact]
        public void Given0WaterQuantity_ThrowInvalidOperationException()
        {
            #region Arrange

            var qty = 0;

            #endregion

            #region Act

            var waterSupplyOrError = WaterSupply.Create(qty);

            #endregion

            #region Assert

            waterSupplyOrError.Invoking(x => x.Value)
                .Should()
                .NotThrow<InvalidOperationException>();

            #endregion
        }
    }
}
