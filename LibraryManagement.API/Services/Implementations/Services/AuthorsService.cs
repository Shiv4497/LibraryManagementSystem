using LibraryManagement.API.Database.Repositories;
using LibraryManagement.API.Models;
using LibraryManagement.API.Services.Interfaces.Repositories;
using LibraryManagement.API.Services.Interfaces.Services;

namespace LibraryManagement.API.Services.Implementations.Services
{
    public class AuthorsService : IAuthorsService
    {
        private IAuthorRepository _authorsRepository;
        private ILogger<AuthorsService> _logger;

        public AuthorsService(IAuthorRepository authorsRepository, ILogger<AuthorsService> logger)
        {
            _authorsRepository = authorsRepository;
            _logger = logger;

        }

        public async Task<Authors> CreateAuthor(Authors author)
        {
            _logger.LogInformation("In AuthorsService.GetAuthors");
            return await _authorsRepository.CreateAuthor(author);
        }

        public async Task DeleteAuthor(Authors author)
        {
            _logger.LogInformation("In AuthorsService.GetAuthors");
            await _authorsRepository.DeleteAuthor(author);
        }

        public async Task<Authors> GetAuthor(int id)
        {
            _logger.LogInformation("In AuthorsService.GetAuthors");
            return await _authorsRepository.GetAuthor(id);
        }

        public async Task<IEnumerable<Authors>> GetAuthors()
        {
            _logger.LogInformation("In AuthorsService.GetAuthors");
            return await _authorsRepository.GetAuthors();
            
        }

        public async Task UpdateAuthor(Authors author)
        {
            _logger.LogInformation("In AuthorsService.GetAuthors");
            await _authorsRepository.UpdateAuthor(author);
        }
    }
}
