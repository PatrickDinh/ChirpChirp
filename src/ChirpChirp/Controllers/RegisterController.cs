using ChirpChirp.Domain;
using Microsoft.AspNet.Mvc;

namespace ChirpChirp.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private readonly AuthRepository _authRepository;

        public RegisterController(AuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async void Register(RegisterDto dto)
        {
            await _authRepository.RegisterUser(dto.Username, dto.Password);
        }
    }

    public class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}