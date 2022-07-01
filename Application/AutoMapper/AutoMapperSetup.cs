using AutoMapper;
using System.Diagnostics.CodeAnalysis;
using Api.Application.AutoMapper;

namespace Api.Application.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public class AutoMapperSetup
    {
        protected AutoMapperSetup()
        {
        }

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
                cfg.AddProfile(new QueryParamMappingProfile());
            });
        }
    }
}
