using RunIt.Common;

namespace RunIt.Domain.ValueObjects
{
    public class Clothes : ValueObject<Clothes>
    {
        public string Items { get; set; }

        public Clothes(string items)
        {
            Items = items;
        }

        protected override bool EqualsCore(Clothes other)
        {
            return Items == other.Items;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Items.GetHashCode();
                hashCode = (hashCode * 397) ^ Items.GetHashCode();

                return hashCode;
            }
        }
    }
}
