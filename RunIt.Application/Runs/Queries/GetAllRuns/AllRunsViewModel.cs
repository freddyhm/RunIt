using System.Collections.Generic;
using RunIt.Runs.Entities;

namespace RunIt.Application.Runs.Queries.GetAllRuns
{
    public class AllRunsViewModel
    {
        public IEnumerable<RunDto> AllRuns { get; set; }
    }
}
