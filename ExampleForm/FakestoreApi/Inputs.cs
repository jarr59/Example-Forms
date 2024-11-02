namespace ExampleForm.FakestoreApi
{
    /// <summary>
    /// representa la entrada de usuario para enviar en la solicitud POST
    /// </summary>
    /// <param name="Email">Correo electrónico del usuario</param>
    /// <param name="Username">Nombre de usuario del usuario</param>
    /// <param name="Password">Contraseña del usuario</param>
    /// <param name="Name">Nombre del usuario (primer nombre y apellido)</param>
    /// <param name="Address">Dirección del usuario</param>
    /// <param name="Phone">Número de teléfono del usuario</param>
    public record UserInput(string Email, string Username, string Password, NameVo Name, AddressVo Address, string Phone);


    /// <summary>
    /// Clase que representa el nombre del usuario
    /// </summary>
    /// <param name="Firstname">Nombres del usuario</param>
    /// <param name="Lastname">Apellidos del usuario</param>
    public record NameVo(string Firstname, string Lastname);

    /// <summary>
    /// Value Object que representa la dirección del usuario
    /// </summary>
    /// <param name="City">Ciudad de residencia del usuario</param>
    /// <param name="Street">Calle de residencia del usuario</param>
    /// <param name="Number">Número de la casa o apartamento del usuario</param>
    /// <param name="Zipcode">Código postal de la dirección del usuario</param>
    /// <param name="Geolocation">Coordenadas de geolocalización de la dirección</param>
    public record AddressVo(string City, string Street, int Number, string Zipcode, GeoLocationVo Geolocation);

    /// <summary>
    /// Value Object que representa las coordenadas de geolocalización
    /// </summary>
    /// <param name="Lat">Latitud de la ubicación</param>
    /// <param name="Long">Longitud de la ubicación</param>
    public record GeoLocationVo(string Lat, string Long);
}
