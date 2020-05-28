using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Common;

namespace RunIt.Runs.ValueObjects
{
    public class Notes : ValueObject<Notes>
    {
        public string Content { get; set; }

        public Notes(string content)
        {
            Content = content;
        }

        protected override bool EqualsCore(Notes other)
        {
            return Content == other.Content;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = Content.GetHashCode();
                hashCode = (hashCode * 397) ^ Content.GetHashCode();

                return hashCode;
            }
        }
    }
}
