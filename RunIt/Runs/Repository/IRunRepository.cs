using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunIt.Runs.Entities;

namespace RunIt.Runs.Repository
{
    public interface IRunRepository
    {
        public List<Run> GetAllRuns();
    }
}
