using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using pinktogether.Models;

namespace DAL.IService
{
    public interface IAppRoleService
    {
        string AddAppRole(AppRole appRole);
        AppRole GetAppRole(string name);
        IQueryable<AppRole> GetAppRole();
        void Update(AppRole appRole);
        void Delete(string id);
    }
}
