using InterviewTask.Common.Entity;
using InterviewTask.Common.Repository;
using InterviewTask.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTask.DataAccess.Repository
{
    class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
