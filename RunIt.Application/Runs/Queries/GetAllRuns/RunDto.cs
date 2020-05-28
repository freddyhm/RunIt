using System;
using System.Collections.Generic;
using System.Text;
using RunIt.Application.Mappings;
using RunIt.Runs.Entities;
using RunIt.Runs.SimpleObjects;
using RunIt.Runs.ValueObjects;

namespace RunIt.Application.Runs.Queries.GetAllRuns
{
    public class RunDto 
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
