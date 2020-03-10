using GymApp.Model.Model;
using GymApp.Repository.IR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Repository.R
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext context)
              : base(context)
        {

        }
        public Country GetById(long id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }

}
