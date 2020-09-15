using System.Collections.Generic;
using RunIt.Common;

namespace RunIt.Domain.ValueObjects
{
    public class FoodBag : ValueObject<FoodBag>
    {
        public List<FoodItem> Items { get; set; }

        protected override bool EqualsCore(FoodBag other)
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
