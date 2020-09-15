using System.Collections.Generic;
using RunIt.Runs.Entities;

namespace RunIt.Web.Api.Runs.Repository
{
    public interface IRunRepository
    {
        public List<Run> GetAllRuns();
    }
}
