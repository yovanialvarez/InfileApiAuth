using ApiAuth.DB;
using ApiAuth.Interface;
using ApiAuth.Models.Authentication;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ApiAuth.Implementacion
{
    public class AuthService: IAuthService
    {
        private readonly MyDbContext _context;

        public AuthService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<UserValidationResponse> IsUserActive(UserValidationRequest userRequest)
        {
            // Search for a user with the given username, password, and active status.
            var user = await _context.Usuarios
                                     .FirstOrDefaultAsync(u => u.NombreUsuario == userRequest.Username
                                                            && u.Password == userRequest.Password
                                                            && u.Activo == true);

            if (user == null)
            {
                return new UserValidationResponse()
                {
                    Success = false,
                    Message = "Error Validar usuario y contraseña",
                    Data = new LoginResponse()
                };
            }

            return new UserValidationResponse()
            {
                Success = true,
                Message = "Autenticacion exitosa",
                Data = new LoginResponse()
                {
                    Name = userRequest.Username
                }
            };
        }
    }
}
