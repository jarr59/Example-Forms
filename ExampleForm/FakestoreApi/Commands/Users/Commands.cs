namespace ExampleForm.FakestoreApi.Commands.Users
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
    public record CreateUser(string Email, string Username, string Password, NameVo Name, AddressVo Address, string Phone);
}
