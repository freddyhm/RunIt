using RunIt.Common;

namespace RunIt.Domain.ValueObjects
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
