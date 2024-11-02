namespace ExampleForms.Web.Example.Components.ViewModels
{
    /// <summary>
    /// View Model del componente <see cref="ProductForm"/> 
    /// </summary>
    public class ProductFormVm
    {
        public ProductFormVm()
        {
            Title = string.Empty;
            Description = string.Empty;
            Image = string.Empty;
            Category = string.Empty;
        }

        /// <summary>
        /// Título del producto
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Precio del producto
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Descripción del producto
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// URL de la imagen del producto
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Categoría del producto
        /// </summary>
        public string Category { get; set; }
    }
}
