using LibraryManagement.API.DTOs;
using LibraryManagement.API.Models;

namespace LibraryManagement.API.Mappers
{
    public static class AuthorsCreateUpdateMapper
    {
        public static Authors Map(this AuthorsCreateUpdateDto authorsCreateDto)
        {
            return new Authors
            {
                Name = authorsCreateDto.Name,
                Bio = authorsCreateDto.Bio,
            };
        }
    }
}
