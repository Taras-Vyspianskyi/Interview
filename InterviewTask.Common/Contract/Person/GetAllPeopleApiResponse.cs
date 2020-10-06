using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InterviewTask.Common.Contract.Person
{
    [DataContract]
    public class GetAllPeopleApiResponse
    {
        public IEnumerable<PersonApiResponse> People { get; set; }
    }
}
