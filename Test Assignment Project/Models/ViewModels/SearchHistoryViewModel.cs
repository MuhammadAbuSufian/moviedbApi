using DotNetCoreApiStarter.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.Entities;

namespace Test_Assignment_Project.Models.ViewModels
{
    public class SearchHistoryViewModel : BaseViewModel<SearchHistory>
    {
        public SearchHistoryViewModel(SearchHistory model) : base(model)
        {
            this.UserId = model.UserId;
            this.SearchResultId = model.SearchResultId;
        }

        public string UserId { get; set; }
        public string SearchResultId { get; set; }

    }
}
