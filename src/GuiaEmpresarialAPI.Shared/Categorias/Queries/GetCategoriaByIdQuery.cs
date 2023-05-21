using GuiaEmpresarialAPI.Shared.Categorias.ViewModels;
using GuiaEmpresarialAPI.Shared.Core.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEmpresarialAPI.Shared.Categorias.Queries
{
    public class GetCategoriaByIdQuery : GetByIdQueryBase<CategoriaViewModel>
    {
    }
}
