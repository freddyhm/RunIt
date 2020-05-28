using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Common;

namespace RunIt.Runs.ValueObjects
{
    public class RunWindSpeed : ValueObject<RunWindSpeed>
    {
        public int Value { get; }

        private RunWindSpeed(int value)
        {
            Value = value;
        }

        public static Result<RunWindSpeed> Create(int windSpeed)
        {
            if (windSpeed <= 0)
                return Result.Fail<RunWindSpeed>("Wind speed must be greater than 0");

            return Result.Ok(new RunWindSpeed(windSpeed));
        }

        protected override bool EqualsCore(RunWindSpeed other)
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
