using MabyJewelrry.DataAccess.Data;
using MabyJewelrry.DataAccess.Repository.IRepository;
using MabyJewelrry.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MabyJewelrry.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
