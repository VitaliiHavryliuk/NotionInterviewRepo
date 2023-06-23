using Domain;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace NotionTestBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddController : ControllerBase
    {
        private readonly IAddService _addService;

        public AddController(IAddService addService)
        {
            _addService = addService;
        }

        [HttpPost]
        public async Task<ActionResult<double>> AddAsync(AddDTO model, CancellationToken cancellationToken)
        {
            return await _addService.AddAsync(model, cancellationToken);
        }
    }
}