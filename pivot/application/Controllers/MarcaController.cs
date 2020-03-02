using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pivot.Application.Infraestrutura;
using Pivot.Domain;

namespace Pivot.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        // TODO interface da application
        // public MarcaController()
        // {

        // }

        [HttpGet]
        public ApiResponse Get()
        {
            return new ApiResponse(new List<Marca> { new Marca { Descricao = "Teste 1" }, new Marca { Descricao = "Marca 2" } });
        }

        [HttpPost]
        public ApiResponse Post([FromBody] Marca marca)
        {
            return new ApiResponse(marca);
        }
    }
}