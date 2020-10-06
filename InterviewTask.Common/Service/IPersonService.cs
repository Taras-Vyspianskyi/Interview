using InterviewTask.Common.Dto;
using InterviewTask.Common.Entity;
using InterviewTask.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Common.Service
{
    public interface IPersonService
    {
        Task<GetAllPeopleResponseDto> GetAllPeopleAsync(GetAllPeopleRequestDto request);
    }
}
