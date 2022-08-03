namespace Project.ENTITIES.Models.User
{
    public class UserGET
    {
        public UserGET()
        {

        }
        public int user_id { get; private set; }
        public int? role_id { get; private set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string bio { get; set; }
        public virtual Role.RoleGET Role { get; set; }
    }
}
