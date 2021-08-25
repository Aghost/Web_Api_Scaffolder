using System;
using System.Linq;
using System.Collections.Generic;
using UserRepositoryApi.Data;
using UserRepositoryApi.Core.Models;
using UserRepositoryApi.Business.Interfaces;

namespace UserRepositoryApi.Business.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepositoryApiDbContext _db;

        public UserService(UserRepositoryApiDbContext db) {
            _db = db;
        }

        // GET ALL
        public List<User> GetAllUsers() {
            return _db.Users.ToList();
        }

        // GET 1
        public User GetUser(int id) {
            return _db.Users.Find(id);
        }

        // GET By Name
        public User GetUser(string name) {
            return _db.Users.FirstOrDefault(user => user.Name == name);
        }

        // ADD
        public void AddUser(string username) {
            var user = new User() { Name = username };

            _db.Add(user);
            _db.SaveChanges();
        }

        // DELETE
        public void DeleteUser(int id) {
            var userToDelete = _db.Users.Find(id);

            if (userToDelete != null) {
                _db.Remove(userToDelete);
            } else {
                throw new InvalidOperationException("no users exists");
            }
        }
    }
}
