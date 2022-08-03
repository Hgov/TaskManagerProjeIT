
using Nelibur.ObjectMapper;

namespace Project.MAPPER.Mappers.UserMap
{
    public class UserMap:IMapper.IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            TinyMapper.Bind<TSource, TDestination>();
            return TinyMapper.Map<TSource, TDestination>(source);
        }
    }
}
