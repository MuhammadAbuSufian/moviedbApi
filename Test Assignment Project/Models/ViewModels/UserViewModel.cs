using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApiStarter.Models.ViewModels
{
    public class UserViewModel : BaseViewModel<User>
    {
        public UserViewModel(User model) : base(model)
        {
            this.Id = model.Id;
            this.Name = model.Name;
        }

        public string Name { get; set; }
        public string Id { get; set; }
    }
}
