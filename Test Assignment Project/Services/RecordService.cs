using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Assignment_Project.Data.Repositories.Interface;
using Test_Assignment_Project.Models.Entities;
using Test_Assignment_Project.Models.RequestModels;
using Test_Assignment_Project.Services.Interface;

namespace Test_Assignment_Project.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRestApiService _restApiService;
        private readonly IRecordRepository _recordRepository;
        public RecordService(IRecordRepository recordRepository, IRestApiService restApiService)
        {
            _restApiService = restApiService;
            _recordRepository = recordRepository;
        }
        public string GetRecord(GetRecordParameter parameters)
        {
            string searchResult = GetSearhResultFromDb(parameters);
            if (searchResult == null)
            {
                searchResult = _restApiService.GetRecord(parameters);
                Save(parameters, searchResult);
            }
            return searchResult;
        }
        public string GetSearhResultFromDb(GetRecordParameter parameters)
        {
            string recordJson;
            var record = _recordRepository.GetAll().Where(x => x.MoviedbId == parameters.RecordId && x.Type == parameters.Type && x.Language == parameters.Language).FirstOrDefault();
            recordJson = record != null ? record.RecordJson : null;
            return recordJson;
        }
        public void Save(GetRecordParameter parameters, string recordJson)
        {
            Record newRecord = new Record()
            {
                MoviedbId = parameters.RecordId,
                Type = parameters.Type,
                Language = parameters.Language,
                RecordJson = recordJson
            };
            _recordRepository.Add(newRecord);
        }

    }
}
