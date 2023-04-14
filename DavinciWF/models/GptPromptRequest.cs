using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavinciWF.models
{
    internal record GptPromptRequest(GptMessage[] messages, int max_tokens=Program.Default_AI_Max_Tokens, double temperature=Program.Default_AI_Temperature, int n=1, string? stop=null);
    //{
    //    public Message[] messages { get; init; }
    //    public int max_tokens { get; init; }
    //    public double temperature { get; init; }
    //    public double frequency_penalty { get; init; }
    //    public double presence_penalty { get; init; }
    //    public double top_p { get; init; }
    //    public string stop { get; init; }
    //}

}
