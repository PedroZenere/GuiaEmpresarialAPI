﻿using GuiaEmpresarialAPI.Application.Categorias.Commands.CreateCategoria;
using GuiaEmpresarialAPI.Application.Categorias.Commands.RemoveCategoria;
using GuiaEmpresarialAPI.Application.Categorias.Queries.GetCategoriaByFilter;
using GuiaEmpresarialAPI.Application.Categorias.Queries.GetCategoriaById;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Utils.PagedList;
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

        [HttpGet("{Id}")]
        public async Task<CategoriaViewModel> BuscaCategoriaById([FromRoute] GetCategoriaByIdQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpGet]
        public async Task<IPaginatedList<CategoriaViewModel>> BuscaCategoriaFiltros([FromQuery] GetCategoriaByFilterQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<CategoriaViewModel> CriaCategoria([FromBody] CreateCategoriaCommand request)
        {
            return await Mediator.Send(request);
        }

        //[HttpPut]
        //public async Task<CategoriaViewModel> AtualizarCategoria([FromBody] CreateOrEditCategoriaCommand request)
        //{
        //    return await Mediator.Send(request);
        //}

        [HttpDelete("{Id}")]
        public async Task<Unit> RemoverCategoriaById([FromRoute] RemoveCategoriaCommand request)
        {
            return await Mediator.Send(request);
        }

    }
}
