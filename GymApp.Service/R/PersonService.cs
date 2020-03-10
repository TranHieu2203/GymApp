using GymApp.Model.Model;
using GymApp.Repository;
using GymApp.Repository.IR;
using GymApp.Service.IR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Service.R
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        IUnitOfWork _unitOfWork;
        IPersonRepository _personRepository;

        public PersonService(IUnitOfWork unitOfWork, IPersonRepository personRepository)
            : base(unitOfWork, personRepository)
        {
            _unitOfWork = unitOfWork;
            _personRepository = personRepository;
        }


        public Person GetById(long Id)
        {
            return _personRepository.GetById(Id);
        }
    }

}
