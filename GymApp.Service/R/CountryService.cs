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
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork _unitOfWork;
        ICountryRepository _countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _countryRepository = countryRepository;
        }


        public Country GetById(long Id)
        {
            return _countryRepository.GetById(Id);
        }
    }

}
