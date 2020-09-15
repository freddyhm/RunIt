using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;
using RunIt.Application.Runs.Queries.GetAllRuns;
using RunIt.Runs.Entities;
using RunIt.Web.Api.Library.Runs.Queries.GetAllRuns;

namespace RunIt.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Run, RunDto>();
        }

       
    }
}
