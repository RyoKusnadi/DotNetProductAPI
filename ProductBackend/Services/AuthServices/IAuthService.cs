using ProductBackend.Dtos;
using ProductBackend.Models;

namespace ProductBackend.Services.AuthServices
{
    public interface IAuthService
    {
        Task<ServiceResponseDto<int>> Register(Users user, string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponseDto<string>> Login(string email, string password);
        Task<ServiceResponseDto<bool>> ChangePassword(int userId, string newPassword);
        Task<ServiceResponseDto<string>> GetUser();
    }
}
