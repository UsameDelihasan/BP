using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BP.Api.Extensions
{
    public static class ConfigureMappingProfileExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(İ => İ.AddProfile(new AutoMapperMappingProfile()));
            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
    }

    public class AutoMapperMappingProfile : Profile
    {
        public AutoMapperMappingProfile()
        {
            CreateMap<Contact, ContactDVO>().ForMember(x => x.FullName, y => y.MapFrom(z => z.FirstName + " " + z.LastName)).ReverseMap();
        }
    }
}
