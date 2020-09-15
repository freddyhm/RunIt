using System;
using RunIt.Domain.Common;
using RunIt.Domain.ValueObjects;

namespace RunIt.Web.Api.Library.Runs.Queries.GetAllRuns
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
