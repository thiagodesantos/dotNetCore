using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pivot.Application.Infraestrutura;
using Pivot.Domain;
using Pivot.Service.Infraestrutura;
using Pivot.Service.Interfaces;

namespace Pivot.Application.Controllers
{
    [Route("api/[controller]/{id?}")]
    [ApiController]
    public class RamoController
    {
        private readonly IRamoService _service;

        public RamoController(IRamoService service)
        {
            this._service = service;
        }

        // [HttpPost]
        // public ApiResponse Post([FromBody] Ramo ramo)
        // {
        //     ramo = this._service.Salvar(ramo);

        //     return new ApiResponse(ramo);
        // }

        [HttpPost]
        public ApiResponse Post([FromBody] ICollection<Ramo> ramos)
        {
            //ramos = this._service.Salvar(ramos);
            this._service.TesteThiago(ramos.First());



            return new ApiResponse(ramos);
        }

        [HttpGet]
        public ApiResponse Get(long? id)
        {
            if (id.HasValue && id > 0)
                return new ApiResponse(this._service.Selecionar(id.Value));
            else
                return new ApiResponse(this._service.SelecionarTodos());
        }

        [HttpDelete]
        public ApiResponse Delete(long id)
        {
            return new ApiResponse(this._service.Remover(id));
        }
    }
}