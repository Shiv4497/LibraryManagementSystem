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

        public async Task DeleteAuthor(Authors author)
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            var deletedEntity = _libraryManagementDbContext.Authors.Remove(author);
            await _libraryManagementDbContext.SaveChangesAsync();
        }

        public async Task<Authors> GetAuthor(int id)
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            return await _libraryManagementDbContext.Authors.AsNoTracking().Where(author => author.AuthorId == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Authors>> GetAuthors()
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            return await _libraryManagementDbContext.Authors.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAuthor(Authors author)
        {
            _logger.LogInformation("In AuthorsRepository.GetAuthors");
            var UpdatedEntity = _libraryManagementDbContext.Authors.Update(author);
            await _libraryManagementDbContext.SaveChangesAsync();

        }
    }
}
