using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DavinciWF.models
{
    public record DavinciPromptRequest([property: JsonPropertyName("prompt")] string Prompt, [property: JsonPropertyName("max_tokens")] int MaxTokens = Program.Default_AI_Max_Tokens, [property: JsonPropertyName("temperature")] double Temperature = Program.Default_AI_Temperature, [property: JsonPropertyName("n")] int N = 1, [property: JsonPropertyName("stream")] bool Stream = false);
}
