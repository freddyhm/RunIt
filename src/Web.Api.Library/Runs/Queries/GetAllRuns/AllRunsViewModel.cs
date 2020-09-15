using System.Collections.Generic;
using RunIt.Runs.Entities;
using RunIt.Web.Api.Library.Runs.Queries.GetAllRuns;

namespace RunIt.Application.Runs.Queries.GetAllRuns
{
    public class AllRunsViewModel
    {
        public IEnumerable<RunDto> AllRuns { get; set; }
    }
}
