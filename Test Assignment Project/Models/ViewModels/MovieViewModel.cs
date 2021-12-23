using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Models.ViewModels
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        public string Adult { get; set; }
        public string Backdrop_path { get; set; }
        public string Genre_ids { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public decimal Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public decimal Vote_average { get; set; }
        public int Vote_count { get; set; }
    }
}
