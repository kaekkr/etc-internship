using ETC_internship.Data;
using ETC_internship.Dtos.User;
using ETC_internship.Interfaces;
using ETC_internship.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ETC_internship.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<User> CreateAsync(User userModel)
        {
            await _context.Users.AddAsync(userModel);
            await _context.SaveChangesAsync();

            return userModel;
        }

        public async Task<User?> DeleteAsync(int id)
        {
            var userModel = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (userModel == null)
            {
                return null;
            }

            _context.Users.Remove(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User?> UpdateAsync(int id, UpdateUserRequestDto updateDto)
        {
            var userModel = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (userModel == null)
            {
                return null;
            }

            var hasher = new PasswordHasher<User>();

            userModel.DepartmentId = updateDto.DepartmentId;
            userModel.PositionId = updateDto.PositionId;
            userModel.RoleId = updateDto.RoleId;
            userModel.FullNameKZ = updateDto.FullNameKZ;
            userModel.FullNameRU = updateDto.FullNameRU;
            userModel.ShortNameKZ = updateDto.ShortNameKZ;
            userModel.ShortNameRU = updateDto.ShortNameRU;
            userModel.FIODatPadejKZ = updateDto.FIODatPadejKZ;
            userModel.FIODatPadejRU = updateDto.FIODatPadejRU;
            userModel.IIN = updateDto.IIN;
            userModel.Email = updateDto.Email;
            userModel.HashedPassword = hasher.HashPassword(userModel, updateDto.Password);

            await _context.SaveChangesAsync();
            return userModel;
        }
    }
}
