using LibraryManagement.API.Models;

namespace LibraryManagement.API.Services.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Authors>> GetAuthors();
        Task<Authors> GetAuthor(int id);
        Task<int> CreateAuthor(Authors author);
        Task UpdateAuthor(Authors author);
        Task DeleteAuthor(int id);
    }
}
