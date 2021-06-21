using Business.Interfaces;
using Business.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class FaturaService : IFaturaService
    {
        private const string urlBase = "https://localhost:44304/api/";

        public async Task<List<Fatura>> ProcessaFaturas()
        {
            var client = new RestClient(urlBase);
            var request = new RestRequest("processar-fatura", DataFormat.Json);
            var response = client.Get<List<Fatura>>(request);

            return await Task.FromResult(response.Data);
        }
    }
}
