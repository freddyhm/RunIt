using RunIt.Common;

namespace RunIt.Domain.ValueObjects
{
    public class Gear : ValueObject<Gear>
    {
        private WaterSupply Quantity { get; set; }
        private FoodBag Food { get; set; }

        public Gear(WaterSupply waterQty, FoodBag food)
        {
            Quantity = waterQty;
            Food = food;
        }

        protected override bool EqualsCore(Gear other)
        {
            return Quantity == other.Quantity && Food == other.Food;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Quantity.GetHashCode();
                hashCode = (hashCode * 397) ^ Food.GetHashCode();

                return hashCode;
            }
        }
    }
}
