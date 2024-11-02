namespace ExampleForm.FakestoreApi
{
    /// <summary>
    /// Value Object que representa la dirección del usuario
    /// </summary>
    /// <param name="City">Ciudad de residencia del usuario</param>
    /// <param name="Street">Calle de residencia del usuario</param>
    /// <param name="Number">Número de la casa o apartamento del usuario</param>
    /// <param name="Zipcode">Código postal de la dirección del usuario</param>
    /// <param name="Geolocation">Coordenadas de geolocalización de la dirección</param>
    public record AddressVo(string City, string Street, int Number, string Zipcode, GeoLocationVo Geolocation);
}
