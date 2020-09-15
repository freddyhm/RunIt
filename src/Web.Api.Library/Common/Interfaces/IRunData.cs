using System.Collections.Generic;
using RunIt.Runs.Entities;

namespace RunIt.Application.Common.Interfaces
{
    public interface IRunData
    {
        IEnumerable<Run> GetAll();
    }
}