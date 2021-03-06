﻿using RunIt.Common;

namespace RunIt.Domain.ValueObjects
{
    public class FoodItem : ValueObject<FoodItem>
    {
        private string Name;
        private int Quantity;

        public FoodItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        protected override bool EqualsCore(FoodItem other)
        {
            return Name == other.Name && Quantity == other.Quantity;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Name.GetHashCode();
                hashCode = (hashCode * 397) ^ Quantity.GetHashCode();

                return hashCode;
            }
        }
    } 
}
