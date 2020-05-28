using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RunIt.Application.Runs.Queries.GetAllRuns;
using RunIt.Runs.Entities;
using RunIt.Runs.Repository;

namespace RunIt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;


        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;

        }

        public async Task<IActionResult> Index()
        {
            var query = new GetAllRunsQuery();
            var result = await _mediator.Send(query);

            return View(result);
        }
    }
}
