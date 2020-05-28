using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Common;

namespace RunIt.Runs.ValueObjects
{
    public class RunTemperature : ValueObject<RunTemperature>
    {
        public int Value { get; }

        public RunTemperature(int value)
        {
            Value = value;
        }

        protected override bool EqualsCore(RunTemperature other)
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
