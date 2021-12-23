using DotNetCoreApiStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Models.Entities
{
    public class SearchResult: BaseEntity
    {
        public string SearchKey { get; set; }
        public string SearchType { get; set; }
        public string Language { get; set; }
        public bool Adult { get; set; }
        public int page { get; set; }
        public string SearchResultJson { get; set; }
    }
}
