using DavinciWF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DavinciWF.services
{
    internal interface IOpenAIService
    {
        HttpClient? AppHttpClient { get; set; }
        Task<DavinciCompletionResponse?> Prompt(DavinciPromptRequest request);
        Task<GptCompletionResponse?> Chat(GptPromptRequest request);
    }
    

    internal class OpenAIService : IOpenAIService
    {
        public string ApiKey { get; set; }
        public HttpClient? AppHttpClient { get; set; }
        public OpenAIService(HttpClient? appHttpClient)
        {
            AppHttpClient = appHttpClient;
        }

        public async Task<DavinciCompletionResponse?> Prompt(DavinciPromptRequest request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            if (AppHttpClient is not null && content is not null)
            {
                var response = await AppHttpClient?.PostAsync(Program.AppSettings.OPENAI_API_DAVINCI_URI, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                var obj = JsonSerializer.Deserialize<DavinciCompletionResponse>(responseString);
                if (obj is not null)
                {
                    return obj;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public async Task<GptCompletionResponse?> Chat(GptPromptRequest request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            if (AppHttpClient is not null && content is not null)
            {
                var response = await AppHttpClient?.PostAsync(Program.AppSettings.OPENAI_API_GPT_URI, content);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                GptCompletionResponse? obj = null;
                try
                {
                    obj = JsonSerializer.Deserialize<GptCompletionResponse>(responseString);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                if (obj is not null)
                {
                    return obj;
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
}
