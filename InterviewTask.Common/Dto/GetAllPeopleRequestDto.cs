using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.Common.Dto
{
    public class GetAllPeopleRequestDto
    {
        public bool HasFaceBookLink { get; set; }

        public int Page { get; set; }

        public int Limit { get; set; }

        public string Order { get; set; }

        public string SortBy { get; set; }
    }
}
