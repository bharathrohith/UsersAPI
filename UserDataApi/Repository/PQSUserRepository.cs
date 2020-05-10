using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDataApi.Models;

namespace UserDataApi.Repository
{
    public class PQSUserRepository : IUserProfileRepository
    {
        private readonly UserProfileContext _userContext;

        public PQSUserRepository(UserProfileContext userContext)
        {
            _userContext = userContext;
        }

        public bool AddUser(UserProfile userToBeAdded)
        {
            var userAdded = _userContext.Users.Add(userToBeAdded);
            _userContext.SaveChanges();
            return true;
        }

        public IEnumerable<UserProfile> GetAllUsers()
        {
            return _userContext.Users.ToList();
        }

        public int GetId(string username)
        {
            return _userContext.Users.FirstOrDefault(user => user.Username == username).Id;
        }

        public string GetUsername(int id)
        {
            return _userContext.Users.FirstOrDefault(user => user.Id == id).Username;
        }
    }
}
