using InterviewTask.Common.Dto;
using InterviewTask.Common.Entity;
using InterviewTask.Common.Enum;
using InterviewTask.Common.Service;
using InterviewTask.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask.Services.Service
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetAllPeopleResponseDto> GetAllPeopleAsync(GetAllPeopleRequestDto requestDto)
        {
            var people = await this.unitOfWork.PersonRepository.GetAllAsync();

            if (!string.IsNullOrEmpty(requestDto.SortBy) && !string.IsNullOrEmpty(requestDto.Order))
            {
                PeopleSortEnum myEnum = (PeopleSortEnum)Enum.Parse(typeof(PeopleSortEnum), requestDto.Order);

                if (myEnum > 0)
                {
                    var pInfo = typeof(Person).GetProperty(requestDto.SortBy);

                    if (pInfo != null)
                    {
                        people = myEnum == PeopleSortEnum.Asc ? people.OrderBy(p => pInfo.GetValue(p, null)) : people.OrderByDescending(p => pInfo.GetValue(p, null));
                    }
                }
            }

            if (requestDto.HasFaceBookLink)
            {
                people = people.Where(p => p.FaceBookLink != null);
            }

            people = people.Skip((requestDto.Page - 1) * requestDto.Limit)
                .Take(requestDto.Limit);

            return new GetAllPeopleResponseDto
            { 
                People = people
            };
        }
    }
}
