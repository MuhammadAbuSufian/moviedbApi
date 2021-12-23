using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApiStarter.Models.ViewModels
{
    public class BaseViewModel<T> where T : BaseEntity
    {
        public BaseViewModel(T model)
        {
            CreatedUserId = model.CreatedUserId;
            CreationTime = model.CreationTime;
            ModifiedUserId = model.ModifiedUserId;
            ModificationTime = model.ModificationTime;
            IsDeleted = model.IsDeleted;
            DeletedUserId = model.DeletedUserId;
            DeletionTime = model.DeletionTime;
        }


        public string CreatedUserId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now.ToUniversalTime();
        public string ModifiedUserId { get; set; }
        public DateTime? ModificationTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string DeletedUserId { get; set; }
        public DateTime? DeletionTime { get; set; }

    }
}
