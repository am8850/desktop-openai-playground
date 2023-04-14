using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinciWF.models
{
    internal record GptCompletionResponse(string id, string @object, long created, string model, GptChoice[] choices, GptUsage usage);
    //{
    //    public string id { get; init; }
    //    public string @object { get; init; }
    //    public long created { get; init; }
    //    public string model { get; init; }
    //    public GptChoice[] choices { get; init; }
    //    public GptUsage usage { get; init; }
    //}

    internal record GptChoice(string text, float logprobs, string finish_reason, GptMessage message);
    //{
    //    public string role { get; init; }
    //    public string content { get; init; }
    //}

    internal record GptUsage(int completion_tokens, int prompt_tokens, int total_tokens);
    //{
    //    public int completion_tokens { get; init; }
    //    public int prompt_tokens { get; init; }
    //    public int total_tokens { get; init; }
    //}

}
