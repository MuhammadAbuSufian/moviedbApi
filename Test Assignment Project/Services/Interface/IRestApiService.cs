using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.RequestModels;

namespace Test_Assignment_Project.Services.Interface
{
    public interface IRestApiService
    {
        string Search(SearchParameter parameters);
        string GetRecord(GetRecordParameter parameters);
    }
}
