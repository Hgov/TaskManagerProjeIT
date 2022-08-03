using Project.ENTITIES.Models.Basic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Project.ENTITIES.Domain
{
    public class User:Base
    {
        public User()
        {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; private set; }
        public int? role_id { get; private set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string password { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Phone]
        public string phone { get; set; }
        public string bio { get; set; }
        [ForeignKey("role_id")]
        [JsonIgnore]
        public virtual Role Role { get; set; }
    }
}
