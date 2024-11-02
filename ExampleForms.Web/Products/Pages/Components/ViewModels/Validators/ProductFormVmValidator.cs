using FluentValidation;

namespace ExampleForms.Web.Products.Pages.Components.ViewModels.Validators
{
    public class ProductFormVmValidator : AbstractValidator<ProductFormVm>
    {
        public ProductFormVmValidator()
        {
            RuleFor(e => e.Title)
                   .MaximumLength(100)
                   .WithMessage($"El maximo de carateres es {100}")
                   .NotEmpty()
                   .WithMessage("El nombre del producto es requerido");

            RuleFor(e => e.Price)
                   .GreaterThan(0)
                   .WithMessage($"El producto debe tener precio mayor a 0$")
                   .NotEmpty()
                   .WithMessage("El precio del producto es requerido");

            RuleFor(e => e.Description)
                   .MaximumLength(500)
                   .WithMessage($"El maximo de carateres es {500}")
                   .NotEmpty()
                   .WithMessage("La descripcion del producto es requerido");


            RuleFor(e => e.Image)
                   .MaximumLength(3000)
                   .WithMessage($"El maximo de carateres es {300}")
                   .NotEmpty()
                   .WithMessage("La imagen del producto es requerido");

            RuleFor(e => e.Category)
                   .MaximumLength(50)
                   .NotEmpty()
                   .WithMessage("La categoria del producto es requerido");
        }
    }
}
