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

            if (authors == null)
                return NotFound();

            return Ok(authors);
        }

        [Route("author")]
        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorsCreateUpdateDto authorDto)
        {
            _logger.LogInformation("In AuthorsController.GetAuthors");
            var author = AuthorsCreateUpdateMapper.Map(authorDto);
            var authorCreated = await _authorsService.CreateAuthor(author);

            return Created($"author/{authorCreated.AuthorId}", authorCreated);
        }

        [Route("author/{authorId:int}")]
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor([FromRoute] int authorId, [FromBody] AuthorsCreateUpdateDto authorDto)
        {
            _logger.LogInformation("In AuthorsController.GetAuthors");
            var author = AuthorsCreateUpdateMapper.Map(authorDto);
            author.AuthorId = authorId;

            var searchAuthor = await _authorsService.GetAuthor(authorId);

            if (searchAuthor == null)
                return NotFound();

            await _authorsService.UpdateAuthor(author);

            return NoContent();
        }

        [Route("author/{authorId:int}")]
        [HttpDelete]
        public async Task<IActionResult> UpdateAuthor([FromRoute] int authorId)
        {
            _logger.LogInformation("In AuthorsController.GetAuthors");

            var searchAuthor = await _authorsService.GetAuthor(authorId);

            if (searchAuthor == null)
                return NotFound();

            await _authorsService.DeleteAuthor(searchAuthor);

            return NoContent();
        }

    }
}


// SOLID principles
// DRY principle