using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.Entities;
using Test_Assignment_Project.Models.ViewModels;

namespace DotNetCoreApiStarter.Models.ViewModels
{
    public class SearchResultViewModel : BaseViewModel<SearchResult>
    {
        public SearchResultViewModel(SearchResult model) : base(model)
        {
            this.SearchKey = model.SearchKey;
            this.Id = model.Id;
            this.SearchType = model.SearchType;
            this.Language = model.Language;
            this.Adult = model.Adult;
            this.page = model.page;
            this.SearchResultJson = model.SearchResultJson;
        }

        public string Id { get; set; }
        public string SearchKey { get; set; }
        public string SearchType { get; set; }
        public string Language { get; set; }
        public bool Adult { get; set; }
        public int page { get; set; }
        public string SearchResultJson { get; set; }

    }
}
