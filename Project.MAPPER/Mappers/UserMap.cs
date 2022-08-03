using Nelibur.ObjectMapper;

namespace Project.MAPPER.Mapper
{
   public  class UserMap
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            TinyMapper.Bind<TSource, TDestination>();
            return TinyMapper.Map<TSource, TDestination>(source);
        }
    }
}
