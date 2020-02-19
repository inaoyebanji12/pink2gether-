using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Model;
using pinktogether.Models;

namespace DAL.IService
{
    public interface IAppUserService
    {
        string AddAppUSer(AppUser appUser);
        AppUser GetAppUser(string FullName);
        IQueryable<AppUser> GetAppUser();
        void Update(AppUser appUser);
        void Delete(string id);
    }
}
