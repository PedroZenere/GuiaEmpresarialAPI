using FluentValidation;

namespace GuiaEmpresarialAPI.Shared.Categorias.Commands
{
    public class CreateOrEditCategoriaCommandValidator : AbstractValidator<CreateOrEditCategoriaCommand>
    {
        public CreateOrEditCategoriaCommandValidator() 
        {
            RuleFor(command => command.Nome)
                .NotEmpty()
                .NotNull();
        }

    }
}
