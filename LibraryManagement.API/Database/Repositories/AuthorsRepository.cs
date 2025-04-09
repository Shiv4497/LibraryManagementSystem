using LibraryManagement.API.Models;
using LibraryManagement.API.Services.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.API.Database.Repositories
{
    public class AuthorsRepository : IAuthorRepository
    {
        private LibraryManagementDbContext _libraryManagementDbContext;
        private ILogger<AuthorsRepository> _logger;
        public AuthorsRepository(LibraryManagementDbContext libraryManagementDbContext, ILogger<AuthorsRepository> logger)
        {
            
            _libraryManagementDbContext = libraryManagementDbContext;
            _logger = logger;
        }

        public async Task<Authors> CreateAuthor(Authors author)
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            var createdEntity =  await _libraryManagementDbContext.Authors.AddAsync(author);
            await _libraryManagementDbContext.SaveChangesAsync();

            return createdEntity.Entity;
        }

        public async Task DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Authors> GetAuthor(int id)
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            return await _libraryManagementDbContext.Authors.Where(author => author.AuthorId == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Authors>> GetAuthors()
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            return await _libraryManagementDbContext.Authors.ToListAsync();
        }

        public async Task UpdateAuthor(Authors author)
        {
            throw new NotImplementedException();
        }
    }
}
