using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.ViewModels;

namespace Test_Assignment_Project.Services.Interface
{
    public interface ISearchHistoryService
    {
        void Save(string userId, string searchId);
        List<SearchHistoryViewModel> GetAll();
    }
}
