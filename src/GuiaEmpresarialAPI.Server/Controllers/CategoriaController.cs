using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Server.Controllers
{
    public class CategoriaController : ApiControllerBase
    {
        public CategoriaController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<CategoriaViewModel> CriaCategoria([FromBody] CreateOrEditCategoriaCommand request)
        {
            var response = await Mediator.Send(request);
            return response;
        }
    }
}
