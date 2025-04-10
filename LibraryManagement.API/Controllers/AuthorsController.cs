using LibraryManagement.API.Database;
using LibraryManagement.API.DTOs;
using LibraryManagement.API.Mappers;
using LibraryManagement.API.Models;
using LibraryManagement.API.Services.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [Route("author/{authorId:int}")]
        [HttpGet]
        public async Task<IActionResult> GetAuthor([FromRoute] int authorId)
        {
            _logger.LogInformation("In AuthorsController.GetAuthors");
            var authors = await _authorsService.GetAuthor(authorId);

            return Ok(authors);
        }

        [Route("author")]
        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorsCreateDto authorDto)
        {
            _logger.LogInformation("In AuthorsController.GetAuthors");
            var author = AuthorsCreateMapper.Map(authorDto);
            var authorCreated = await _authorsService.CreateAuthor(author);

            return Created($"author/{authorCreated.AuthorId}", authorCreated);
        }

    }
}


// SOLID principles
// DRY principle