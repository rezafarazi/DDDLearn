using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastacture.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<tbl_users> AddNewUser(tbl_users NUser, CancellationToken cancellationToken = default)
        {
            await _context.Users.AddAsync(NUser);            
            return NUser;
        }

        public async Task<tbl_users> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Users.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task<List<tbl_users>> GetUsersList(CancellationToken cancellationToken = default)
        {
            return await _context.Users.ToListAsync(cancellationToken);
        }

        public async Task<tbl_users> UpdateAsync(tbl_users Uuser, CancellationToken cancellationToken = default)
        {
            _context.Users.Update(Uuser);
            return Uuser;
        }
    }
}
