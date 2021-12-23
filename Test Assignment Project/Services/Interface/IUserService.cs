using DotNetCoreApiStarter.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Services.Interface
{
    public interface IUserService
    {
        void Save(string name);
        UserViewModel GetUserByName(string name);
        UserViewModel GetUserById(string Id);
    }
}
