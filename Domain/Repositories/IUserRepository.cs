using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        Task<tbl_users> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<List<tbl_users>> GetUsersList(CancellationToken cancellationToken = default);
        Task<tbl_users> AddNewUser(tbl_users NUser, CancellationToken cancellationToken = default);
        Task<tbl_users> UpdateAsync(tbl_users Uuser, CancellationToken cancellationToken = default);


    }
}
