using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Common;
using RunIt.Domain.Common;
using RunIt.Domain.ValueObjects;

namespace RunIt.Runs.Entities
{
    public class Run : Entity
    {
        public DateTime Date { get; set; }
        public RunDistance Distance { get; set; }
        public RunType Type { get; set; }
        public RunTemperature RunTemperature { get; set; }
        public RunWindSpeed RunWindSpeed { get; set; }
        public Clothes Clothes { get; set; }
        public SatisfactionLevel SatisfactionLevel { get; set; }
        public Notes Notes { get; set; }
        public Gear Gear { get; set; }
    }
}
