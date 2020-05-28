using RunIt.Common;

namespace RunIt.Domain.ValueObjects
{
    public class RunDistance : ValueObject<RunDistance>
    {
        public double Value { get; }

        private RunDistance(double value)
        {
            Value = value;
        }

        public static Result<RunDistance> Create(double distance)
        {
            if (distance <= 0)     
                return Result.Fail<RunDistance>("Distance must be greater than 0");

            return Result.Ok(new RunDistance(distance));
        }

        protected override bool EqualsCore(RunDistance other)
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
