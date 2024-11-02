using FluentValidation;

namespace ExampleForms.Web.Example.Components.ViewModels.Validators
{
    public class ProductFormVmValidator : AbstractValidator<ProductFormVm>
    {
        public ProductFormVmValidator()
        {
            RuleFor(e => e.Title)
                   .MaximumLength(100)
                   .WithMessage("El maximo de caracteres es 100")
                   .NotEmpty()
                   .WithMessage("El nombre del producto es requerido");
        }
    }
}
