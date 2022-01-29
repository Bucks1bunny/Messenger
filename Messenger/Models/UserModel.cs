using System.ComponentModel.DataAnnotations;


namespace Messenger.Models
{
    public class UserModel
    {
        public int userid { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}