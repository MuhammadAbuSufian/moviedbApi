using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Assignment_Project.Models.RequestModels;
using Test_Assignment_Project.Services.Interface;

namespace Test_Assignment_Project.Services
{
    public class RestApiService: IRestApiService
    {
        IConfiguration Configuration;
        public RestApiService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string Search(SearchParameter parameters)
        {
            string baseUrl = Configuration["MovieDbBaseUrls"];
            string subUrl = GenSearchSubUrl(parameters);
            var client = new RestClient(baseUrl);
            var request = new RestRequest(subUrl, DataFormat.Json);
            string response;
            try
            {
                response = client.Get(request).Content;
            }
            catch(Exception e)
            {
                throw;
            }
            return response;
        }

        public string GenSearchSubUrl(SearchParameter parameters)
        {
            var subUrl = new StringBuilder("search/");
            switch (parameters.Type)
            {
                case "person":
                    subUrl.Append("person");
                    break;
                case "tv":
                    subUrl.Append("tv");
                    break;
                default :
                    subUrl.Append("movie");
                    break;
            }
            string queryParameterString = GenSearchQueryParameters(parameters);
            subUrl.Append(queryParameterString);
            return subUrl.ToString();
        }
        public string GenSearchQueryParameters(SearchParameter parameters)
        {
            string apiKey = Configuration["MovieDbApiKey"];
            var queryParameters = new StringBuilder("?api_key=");
            queryParameters.Append(apiKey);
            queryParameters.Append("&include_adult=");
            queryParameters.Append(parameters.Adult);
            if (parameters.Key != null)
            {
                queryParameters.Append("&query=");
                queryParameters.Append(parameters.Key);
            }
            if (parameters.Language != null)
            {
                queryParameters.Append("&language=");
                queryParameters.Append(parameters.Language);
            }
            if (parameters.Page != 0)
            {
                queryParameters.Append("&page=");
                queryParameters.Append(parameters.Page);
            }
            return queryParameters.ToString();
        }

        public string GetRecord(GetRecordParameter parameters)
        {
            string baseUrl = Configuration["MovieDbBaseUrls"];
            string subUrl = GenGetRecordUrl(parameters);
            var client = new RestClient(baseUrl);
            var request = new RestRequest(subUrl, DataFormat.Json);
            string response;
            try
            {
                response = client.Get(request).Content;
            }
            catch (Exception e)
            {
                throw;
            }
            return response;
        }

        public string GenGetRecordUrl(GetRecordParameter parameters)
        {
            var subUrl = new StringBuilder(parameters.Type);
            subUrl.Append("/");
            subUrl.Append(parameters.RecordId);
            string queryParameterString = GenGetRecordQueryParameters(parameters);
            subUrl.Append(queryParameterString);
            return subUrl.ToString();
        }
        public string GenGetRecordQueryParameters(GetRecordParameter parameters)
        {
            string apiKey = Configuration["MovieDbApiKey"];
            var queryParameters = new StringBuilder("?api_key=");
            queryParameters.Append(apiKey);
            if (parameters.Language != null)
            {
                queryParameters.Append("&language=");
                queryParameters.Append(parameters.Language);
            }
            return queryParameters.ToString();
        }
    }
}
