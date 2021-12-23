using DotNetCoreApiStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Models.Entities
{
    public class Record: BaseEntity
    {
        public int MoviedbId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string RecordJson { get; set; }
    }
}
