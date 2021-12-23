using DotNetCoreApiStarter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Models.Entities
{
    public class SearchHistory: BaseEntity
    {
        public string UserId { get; set; }
        public string SearchResultId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("SearchResultId")]
        public virtual SearchResult SearchResult { get; set; }
    }
}
