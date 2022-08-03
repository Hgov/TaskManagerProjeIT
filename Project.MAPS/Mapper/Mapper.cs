using Nelibur.ObjectMapper;
namespace Project.MAPS.Mapper
{
    public class Mapper : IMapper.IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            TinyMapper.Bind<TSource, TDestination>();
            return TinyMapper.Map<TSource, TDestination>(source);
        }
    }
}
