using EntityFramework.Database;
using EntityFramework.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Services
{
    public class UserService
    {
        private ApplicationDbContext DbContext { get; }
        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public User FindById(int id)
        {
            return DbContext.Users.Find(id);
        }
        public User Add(User user)
        {
            var savedUser = DbContext.Users.Add(user).Entity;
            DbContext.SaveChanges();
            return savedUser;
        }
        public List<User> Findall()
        {
            return DbContext.Users.ToList();
        }
    }
}
