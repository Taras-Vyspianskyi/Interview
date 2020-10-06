using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InterviewTask.Common.Contract.Person;
using InterviewTask.Common.Dto;
using InterviewTask.Common.Enum;
using InterviewTask.Common.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTask.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService personService;
        private readonly IMapper mapper;

        public PersonController(IPersonService personService, IMapper mapper)
        {
            this.personService = personService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<GetAllPeopleApiResponse> GetAllPeople([FromQuery] GetAllPeopleApiRequest request)
        {
            var response = await this.personService.GetAllPeopleAsync(this.mapper.Map<GetAllPeopleRequestDto>(request));

            return new GetAllPeopleApiResponse { 
                People = response.People.Select(p => this.mapper.Map<PersonApiResponse>(p))
            };
        }
    }
}