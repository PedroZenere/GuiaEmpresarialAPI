using FluentValidation;

namespace GuiaEmpresarialAPI.Application.Categorias.Commands.CreateCategoria
{
    public class CreateOrEditCategoriaCommandValidator : AbstractValidator<CreateCategoriaCommand>
    {
        public CreateOrEditCategoriaCommandValidator() 
        {
            RuleFor(command => command.Nome)
                .NotEmpty()
                .NotNull();
        }

    }
}
