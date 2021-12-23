using DotNetCoreApiStarter.Data;
using DotNetCoreApiStarter.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Data.Repositories.Interface;
using Test_Assignment_Project.Models.Entities;

namespace Test_Assignment_Project.Data.Repositories
{
    public class SearchHistoryRepository : BaseRepository<SearchHistory>, ISearchHistoryRepository
    {
        public SearchHistoryRepository(BusinessDbContext db) : base(db)
        {
        }
    }
}
