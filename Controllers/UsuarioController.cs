using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using project1.Models;

namespace project1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public int Post([FromBody] UsuarioModel usuario)
        {
            return usuario.Name == "Davi" && usuario.Password == "123" ? 1 : 0;
        }
    }
}
