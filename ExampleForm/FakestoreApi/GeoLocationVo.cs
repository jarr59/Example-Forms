namespace ExampleForm.FakestoreApi
{
    /// <summary>
    /// Value Object que representa las coordenadas de geolocalización
    /// </summary>
    /// <param name="Lat">Latitud de la ubicación</param>
    /// <param name="Long">Longitud de la ubicación</param>
    public record GeoLocationVo(string Lat, string Long);
}
