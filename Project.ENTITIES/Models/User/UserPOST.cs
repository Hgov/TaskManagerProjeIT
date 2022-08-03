namespace Project.ENTITIES.Models.User
{
    public class UserPOST
    {
        public int? role_id { get; private set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string bio { get; set; }
    }
}
