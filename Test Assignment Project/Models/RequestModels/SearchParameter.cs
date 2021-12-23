using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Models.RequestModels
{
    public class SearchParameter
    {
        public string User { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public bool Adult { get; set; }
        public int Page { get; set; }
    }
}
