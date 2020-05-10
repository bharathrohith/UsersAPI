using System.ComponentModel.DataAnnotations;

namespace UserDataApi.Models
{
    public class UserProfile
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Username { get; set; }

        public UserProfile()
        {

        }
        public UserProfile(int id, string username)
        {
            this.Id = id;
            this.Username = username;
        }
    }
}

