using InterviewTask.Common.Contract.Person;
using InterviewTask.Common.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Common.Dto
{
    public class GetAllPeopleResponseDto
    {
        public IEnumerable<Person> People { get; set; }
    }
}
