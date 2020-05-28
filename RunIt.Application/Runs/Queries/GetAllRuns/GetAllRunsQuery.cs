using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RunIt.Application.Common.Interfaces;
using RunIt.Runs.Entities;

namespace RunIt.Application.Runs.Queries.GetAllRuns
{
    public class GetAllRunsQuery : IRequest<AllRunsViewModel>
    {
        public class GetAllRunsQueryHandler : IRequestHandler<GetAllRunsQuery, AllRunsViewModel>
        {
            private readonly IRunData _runData;
            private readonly IMapper _mapper;

            public GetAllRunsQueryHandler(IRunData runData, IMapper mapper)
            {
                _runData = runData;
                _mapper = mapper;
            }

            public async Task<AllRunsViewModel> Handle(GetAllRunsQuery request, CancellationToken cancellationToken)
            {
                var runs = _runData.GetAll();
                var runsDto = _mapper.Map<IEnumerable<Run>, IEnumerable<RunDto>>(runs);

                var allRunsViewModel = new AllRunsViewModel
                {
                    AllRuns = runsDto
                };

                return allRunsViewModel;
            }
        }
    }
}