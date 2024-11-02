using ExampleForm.FakestoreApi.Commands.Users;
using Refit;

namespace ExampleForm.FakestoreApi.Sdks
{
    public interface IUserSdk
    {
        /// <summary>
        /// Url de Fakestore en el endpoints de usuario
        /// </summary>
        const string URL = "https://fakestoreapi.com/users";

        /// <summary>
        /// Crea un usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [Post(URL)]
        Task AddUser(CreateUser user);

        //Task<List<User>> GetAllUsers();
        //Task<User> GetUserById(int userId);
        //Task<List<User>> GetUsersByLimit(int limit);
        //Task<List<User>> GetUsersSorted(string sort);
        //Task UpdateUser(int userId, User user);
        //Task DeleteUser(int userId);
        //Task<User> Login(string username, string password);
    }

}
