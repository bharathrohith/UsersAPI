using System.Collections.Generic;
using UserDataApi.Models;

namespace UserDataApi.Repository
{
    public interface IUserProfileRepository
    {
        string GetUsername(int id);
        int GetId(string username);
        bool AddUser(UserProfile userToBeAdded);
        IEnumerable<UserProfile> GetAllUsers();
    }
}