using AutoMapper;
using InterviewTask.Common.Contract.Person;
using InterviewTask.Common.Dto;
using InterviewTask.Common.Entity;

namespace InterviewTask.Common.Mapping
{
    public class PersonMapProfile : Profile
    {
        public PersonMapProfile()
        {
            CreateMap<Person, PersonApiResponse>();
            CreateMap<GetAllPeopleApiRequest, GetAllPeopleRequestDto>();
            CreateMap<GetAllPeopleResponseDto, GetAllPeopleApiResponse>();
        }
    }
}
