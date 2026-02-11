using Lection.Models;

namespace Lection.Services
{

    public class UserService
    {
        private static readonly List<User> users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Username = "JohnDoe",
                Age = 30,
                Email = "salmon@gmail.com",
                Password = "password123"
            },
            new User
            {
                Id = Guid.NewGuid(),
                Username = "JaneSmith",
                Age = 25,
                Email = "fds@gmail.com",
                Password = "password456"
            }
        };

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(Guid id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
        public User Register(User newUser)
        {
            var id = new Guid();
            newUser.Id = id;

            users.Add(newUser);
            return newUser;
        }

    }
}
