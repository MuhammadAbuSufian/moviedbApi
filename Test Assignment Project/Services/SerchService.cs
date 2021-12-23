using DotNetCoreApiStarter.Models.ViewModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Data.Repositories.Interface;
using Test_Assignment_Project.Models.Entities;
using Test_Assignment_Project.Models.RequestModels;
using Test_Assignment_Project.Services.Interface;

namespace Test_Assignment_Project.Services
{
    public class SerchService : ISearchService
    {
        private readonly IRestApiService _restApiService;
        private readonly IUserService _userService;
        private readonly ISearchHistoryService _searchHistoryService;
        private readonly ISearchResultRepository _searchResultRepository;
        public SerchService(IRestApiService restApiService,
            ISearchResultRepository searchResultRepository,
            ISearchHistoryService searchHistoryService,
            IUserService userService)
        {
            _restApiService = restApiService;
            _searchResultRepository = searchResultRepository;
            _searchHistoryService = searchHistoryService;
            _userService = userService;
        }
        public string Search(SearchParameter parameters)
        {
            SearchResultViewModel searchResult = GetSearhResultFromDb(parameters);
            if(searchResult == null)
            {
                string newSearchResult = _restApiService.Search(parameters);
                searchResult =  Save(parameters, newSearchResult);
            }
            var user = _userService.GetUserByName(parameters.User);
            _searchHistoryService.Save(user.Id, searchResult.Id);
            return searchResult.SearchResultJson;
        }
        public SearchResultViewModel GetSearhResultFromDb(SearchParameter parameters)
        {
            SearchResult entity = _searchResultRepository.GetAll().Where(x => x.SearchKey == parameters.Key && x.Adult == parameters.Adult && x.Language == parameters.Language && x.SearchType == parameters.Type).FirstOrDefault();
            SearchResultViewModel model = entity != null ? new SearchResultViewModel(entity) : null;
            return model;
        }
        public SearchResultViewModel Save(SearchParameter parameters, string searchResultJson)
        {
            SearchResult newSearchResult = new SearchResult()
            {
                SearchKey = parameters.Key,
                SearchType = parameters.Type,
                Language = parameters.Language,
                Adult = parameters.Adult,
                page = parameters.Page,
                SearchResultJson = searchResultJson
            };
            _searchResultRepository.Add(newSearchResult);
            return new SearchResultViewModel(newSearchResult);
        }
    }
}
