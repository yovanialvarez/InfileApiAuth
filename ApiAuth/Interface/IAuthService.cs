using ApiAuth.Models.Authentication;

namespace ApiAuth.Interface
{
    public interface IAuthService
    {
        Task<UserValidationResponse> IsUserActive(UserValidationRequest userRequest);
    }
}
