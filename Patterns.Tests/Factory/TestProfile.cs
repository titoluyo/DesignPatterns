using AutoMapper;

namespace Patterns.Tests.Factory
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<Person, PersonDTO>();
        }
    }
}
