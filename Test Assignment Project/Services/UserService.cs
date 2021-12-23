using DotNetCoreApiStarter.Data.Repositories;
using DotNetCoreApiStarter.Models;
using DotNetCoreApiStarter.Models.RequestModels;
using DotNetCoreApiStarter.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Data.Repositories.Interface;
using Test_Assignment_Project.Services.Interface;

namespace DotNetCoreApiStarter.Services
{
   
    public class UserService: IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        void IUserService.Save(string name)
        {
            User newUser = new User() { Name = name };
            _repository.Add(newUser);
        }
        public UserViewModel Save(string name)
        {
            User newUser = new User() { Name = name };
            _repository.Add(newUser);
            return new UserViewModel(newUser);
        }
        public UserViewModel GetUserByName(string name)
        {
            User user = _repository.GetAll().Where(x => x.Name == name).FirstOrDefault();
            UserViewModel userViewModel = user == null ? Save(name) : new UserViewModel(user);
            return userViewModel;
        }
        public UserViewModel GetUserById(string Id)
        {
            User user = _repository.GetById(Id);
            UserViewModel userViewModel = new UserViewModel(user);
            return userViewModel;
        }

       
    }
}
