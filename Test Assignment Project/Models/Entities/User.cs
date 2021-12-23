using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApiStarter.Models
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
    }
}
