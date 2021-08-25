using System.Collections.Generic;
using UserRepositoryApi.Core.Models;

namespace UserRepositoryApi.Business.Interfaces {
    public interface IUserService {
        public List<User> GetAllUsers();
        public User GetUser(int id);
        public User GetUser(string name);
        public void AddUser(string userName);
        public void DeleteUser(int id);
    }
}
