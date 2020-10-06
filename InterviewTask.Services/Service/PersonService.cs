using InterviewTask.Common.Entity;
using InterviewTask.Common.Service;
using InterviewTask.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public async Task<IEnumerable<Person>> GetAllPeopleAsync()
        {
            var people = await this.unitOfWork.PersonRepository.GetAllAsync();

            return people;
        }

        public async Task<IEnumerable<Person>> GetPeopleFilteredAsync(Expression<Func<Person, bool>> predicate)
        {
            var filteredPeople = await this.unitOfWork.PersonRepository.FilterByAsync(predicate);

            return filteredPeople;
        }
    }
}
