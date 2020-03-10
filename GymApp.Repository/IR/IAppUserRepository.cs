using GymApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Repository.IR
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        AppUser GetById(long id);
        AppUser ReadByUserName(string userName);
    }

}
