using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Common;

namespace RunIt.Runs.ValueObjects
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
