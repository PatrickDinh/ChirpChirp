using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ChirpChirp.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        public void Register(RegisterDto dto)
        {

        }
    }

    public class RegisterDto
    {
        public string Username { get; set; }
        public string Passwrod { get; set; }
    }
}
