using System.Collections.Generic;
using UserDataApi.Models;

namespace UserDataApi.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        public string GetUsername(int id)
        {
            if (id == 1)
            {
                return "Bharath";
            }
            else if (id == 2)
            {
                return "Rohith";
            }
            return "User Not found";
        }

        public int GetId(string username)
        {
            if (username.Equals("Bharath"))
            {
                return 1;
            }
            else if (username.Equals("Rohith"))
            {
                return 2;
            }
            return 0;
        }

        public IEnumerable<UserProfile> GetAllUsers()
        {
            var users = new List<UserProfile>
            {
                new UserProfile(1,"Bharath"),
                new UserProfile(2,"Rohith")
            };
            return users;
        }

        public bool AddUser(UserProfile userToBeAdded)
        {
            throw new System.NotImplementedException();
        }
    }
}