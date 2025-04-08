using LibraryManagement.API.Services.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthorsService _authorsService;
        private ILogger<AuthorsController> _logger;

        public AuthorsController(IAuthorsService authorsService, ILogger<AuthorsController> logger)
        {
            _authorsService = authorsService;
            _logger = logger;

        }

        [Route("authors")]
        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            _logger.LogInformation("In AuthorsController.GetAuthors");
            var authors = await _authorsService.GetAuthors();

            return Ok(authors);
        }
    }
}
