using AutoMapper;
using GuiaEmpresarialAPI.Data.Interface;
using GuiaEmpresarialAPI.Domain.Categorias.Entities;
using GuiaEmpresarialAPI.Shared.Categorias.Commands;
using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.Services
{
    public class CategoriaCommandServices : ICategoriaCommandServices
    {
        protected readonly IApplicationContext _appContext;
        protected readonly IMapper _mapper;

        public CategoriaCommandServices(IApplicationContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }
        public async Task<CategoriaViewModel> Atualizar(CreateOrEditCategoriaCommand command, CancellationToken cToken)
        {
            var entity = _mapper.Map<Categoria>(command);

            var response = _appContext.Categorias.Update(entity);
            await _appContext.SaveChangesAsync(cToken);

            return _mapper.Map<CategoriaViewModel>(response.Entity);
        }

        public async Task<CategoriaViewModel> Criar(CreateOrEditCategoriaCommand command, CancellationToken cToken)
        {
            var entity = _mapper.Map<Categoria>(command);

            var response = await _appContext.Categorias.AddAsync(entity, cToken);
            await _appContext.SaveChangesAsync(cToken);

            return _mapper.Map<CategoriaViewModel>(response.Entity);
        }

        public async Task<Unit> Deletar(Guid Id, CancellationToken cToken)
        {
            var entity = await _appContext.Categorias.FirstOrDefaultAsync(x => x.Id == Id);
            var query = _appContext.Categorias.Remove(entity);

            await _appContext.SaveChangesAsync(cToken);

            return Unit.Value;
        }
    }
}
