using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using UserDataApi.Models;
using UserDataApi.Repository;

namespace UserDataApi.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserProfileRepository _userRepo;

        public UsersController(IUserProfileRepository userRepo)
        {
            _userRepo = userRepo;
        }

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserProfile>> GetAllUsers()
        {
            var users = _userRepo.GetAllUsers();

            return Ok(users);
        }

        //GET api/users/{id}
        [HttpGet("id={id}")]
        public ActionResult<string> GetUsername(int id)
        {
            var user = _userRepo.GetUsername(id);

            return Ok(user);
        }

        //GET api/users/{username}
        [HttpGet("username={username}")]
        public ActionResult<string> GetId(string username)
        {
            var user_id = _userRepo.GetId(username);

            return Ok(user_id);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult<UserProfile> AddUser([FromBody]UserProfile userToBeAdded)
        {
            try
            {
                bool userAdded = _userRepo.AddUser(userToBeAdded);
                return Ok(userAdded);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return BadRequest();
        }
    }
}

