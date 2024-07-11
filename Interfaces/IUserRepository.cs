using ETC_internship.Dtos.User;
using ETC_internship.Models;

namespace ETC_internship.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User> CreateAsync(User userModel);
        Task<User?> UpdateAsync(int id, UpdateUserRequestDto updateDto);
        Task<User?> DeleteAsync(int id);
    }
}
