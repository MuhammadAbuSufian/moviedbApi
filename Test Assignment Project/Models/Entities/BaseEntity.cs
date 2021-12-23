using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApiStarter.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CreatedUserId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now.ToUniversalTime();

        public string ModifiedUserId { get; set; }
        public DateTime? ModificationTime { get; set; }

        public bool IsDeleted { get; set; } = false;
        public string DeletedUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
