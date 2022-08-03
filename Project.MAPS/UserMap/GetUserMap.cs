using Nelibur.ObjectMapper;


namespace Project.MAPS.UserMap
{
   public class GetUserMap
    {
        public UserGET Map<User, UserGET>(User user)
        {
            TinyMapper.Bind<User, UserGET>(config=> {
                config.Bind(source=>);
            });
            return TinyMapper.Map<User, UserGET>(user);
        }
    }
}
