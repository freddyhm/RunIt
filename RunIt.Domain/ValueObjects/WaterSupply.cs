using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Common;

namespace RunIt.Runs.ValueObjects
{
    public class WaterSupply : ValueObject<WaterSupply>
    {
        public double Value { get; }

        private WaterSupply(double value)
        {
            Value = value;
        }

        public static Result<WaterSupply> Create(double quantity)
        {
            if (quantity < 0)
                return Result.Fail<WaterSupply>("Water supply cannot be negative");

            return Result.Ok(new WaterSupply(quantity));
        }

        protected override bool EqualsCore(WaterSupply other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Value.GetHashCode();
                hashCode = (hashCode * 397) ^ Value.GetHashCode();

                return hashCode;
            }
        }
    }
}
