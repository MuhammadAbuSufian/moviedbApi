using DotNetCoreApiStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Data.Repositories.Interface;

namespace DotNetCoreApiStarter.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(BusinessDbContext db) : base(db)
        {
        }
    }
}
