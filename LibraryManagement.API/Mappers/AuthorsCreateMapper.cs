using LibraryManagement.API.DTOs;
using LibraryManagement.API.Models;

namespace LibraryManagement.API.Mappers
{
    public static class AuthorsCreateMapper
    {
        public static Authors Map(this AuthorsCreateDto authorsCreateDto)
        {
            return new Authors
            {
                Name = authorsCreateDto.Name,
                Bio = authorsCreateDto.Bio,
            };
        }
    }
}
