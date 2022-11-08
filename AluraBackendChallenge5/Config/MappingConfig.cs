using AluraBackendChallenge5.Data.ValueObjects;
using AluraBackendChallenge5.Models.Base;
using AutoMapper;

namespace AluraBackendChallenge5.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<VideoVO, VideoEntity>();
                config.CreateMap<VideoEntity, VideoVO>();

                config.CreateMap<CategoriaVO, CategoriaEntity>();
                config.CreateMap<CategoriaEntity, CategoriaVO>();
            });

            return mappingConfig;
        }
    }
}
