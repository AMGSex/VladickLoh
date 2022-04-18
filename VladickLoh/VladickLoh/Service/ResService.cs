using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using VladickLoh.Model;
using System.Diagnostics;

namespace VladickLoh.Service
{
    public class ResService : IRestServise
    {
        List<EntryModel> EntryModels { get; set; }
        EntryContainer Container { get; set; }
        JsonSerializerOptions JsonSerializerOptions;
        HttpClient HttpClient = new HttpClient();

        public ResService()
        {
            JsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }
        
        async Task<List<EntryModel>> IRestServise.GetDataAsync()
        {
            EntryModels = new List<EntryModel>();
            Container = new EntryContainer();
            var httpResponsee = await HttpClient.GetAsync(Consts.URI);
            try
            {
                if(httpResponsee.IsSuccessStatusCode)
                {
                    string content = await httpResponsee.Content.ReadAsStringAsync();

                    Container = JsonSerializer.Deserialize<EntryContainer>(content);
                    EntryModels = Container.EntryModels;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return EntryModels;
        }
    }
}
