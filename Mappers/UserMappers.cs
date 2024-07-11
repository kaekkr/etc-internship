using ETC_internship.Dtos.User;
using ETC_internship.Models;
using Microsoft.AspNetCore.Identity;

namespace ETC_internship.Mappers
{
    public static class UserMappers
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                Id = userModel.Id,
                DepartmentId = userModel.DepartmentId,
                PositionId = userModel.PositionId,
                RoleId = userModel.RoleId,
                FullNameKZ = userModel.FullNameKZ,
                FullNameRU = userModel.FullNameRU,
                ShortNameKZ = userModel.ShortNameKZ,
                ShortNameRU = userModel.ShortNameRU,
                FIODatPadejKZ = userModel.FIODatPadejKZ,
                FIODatPadejRU = userModel.FIODatPadejRU,
                IIN = userModel.IIN,
                Email = userModel.Email,
                IsActivated = userModel.IsActivated,
                CreatedDate = userModel.CreatedDate,
                ModifiedDate = userModel.ModifiedDate
            };
        }

        public static User ToUserFromCreateDto(this CreateUserRequestDto userDto)
        {
            var hasher = new PasswordHasher<User>();
            var user = new User
            {
                DepartmentId = userDto.DepartmentId,
                PositionId = userDto.PositionId,
                RoleId = userDto.RoleId,
                FullNameKZ = userDto.FullNameKZ,
                FullNameRU = userDto.FullNameRU,
                ShortNameKZ = userDto.ShortNameKZ,
                ShortNameRU = userDto.ShortNameRU,
                FIODatPadejKZ = userDto.FIODatPadejKZ,
                FIODatPadejRU = userDto.FIODatPadejRU,
                IIN = userDto.IIN,
                Email = userDto.Email
            };

            user.HashedPassword = hasher.HashPassword(user, userDto.Password);
            return user;
        }
    }
}
