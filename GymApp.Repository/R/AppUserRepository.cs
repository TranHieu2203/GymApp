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
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(DbContext context)
            : base(context)
        {

        }
        public override IEnumerable<AppUser> GetAll()
        {
            return _entities.Set<AppUser>().AsEnumerable();
        }

        public AppUser GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
        public AppUser ReadByUserName( string userName)
        {
            var dbUser = FindBy(x => x.UserName.ToUpper().Equals(userName.ToUpper()) && x.Active & !x.IsLock).FirstOrDefault();
            return dbUser;
        }
        public AppUser ReadByUserNameWithExited(string userName)
        {
            var dbUser = FindBy(x => x.UserName.ToUpper().Equals(userName.ToUpper())).FirstOrDefault();
            return dbUser;
        }
    }
}
