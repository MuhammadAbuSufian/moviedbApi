using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Data.Repositories.Interface;
using Test_Assignment_Project.Models.Entities;
using Test_Assignment_Project.Models.ViewModels;
using Test_Assignment_Project.Services.Interface;

namespace Test_Assignment_Project.Services
{
    public class SearchHistoryService: ISearchHistoryService
    {
        private readonly ISearchHistoryRepository _searchHistoryRepository;
        public SearchHistoryService(ISearchHistoryRepository searchHistoryRepository)
        {
            _searchHistoryRepository = searchHistoryRepository;
        }

        public void Save(string userId, string searchId)
        {
            SearchHistory newHistory = new SearchHistory()
            {
                UserId = userId,
                SearchResultId = searchId
            };
            _searchHistoryRepository.Add(newHistory);
        }
        public List<SearchHistoryViewModel> GetAll()
        {
            List<SearchHistory> entities = _searchHistoryRepository.GetAll().ToList();
            List<SearchHistoryViewModel> histories = entities.ConvertAll(x => (SearchHistoryViewModel)Activator.CreateInstance(typeof(SearchHistoryViewModel), x));
            return histories;
        }

    }
}
