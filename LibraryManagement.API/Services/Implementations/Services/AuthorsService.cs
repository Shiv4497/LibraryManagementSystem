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

        public async Task<int> CreateAuthor(Authors author)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Authors> GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Authors>> GetAuthors()
        {
            _logger.LogInformation("In AuthorsService.GetAuthors");
            return await _authorsRepository.GetAuthors();
            
        }

        public async Task UpdateAuthor(Authors author)
        {
            throw new NotImplementedException();
        }
    }
}
