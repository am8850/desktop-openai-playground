using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DavinciWF.models
{
    public record Choice([property: JsonPropertyName("text")] string Text, [property: JsonPropertyName("index")] int Index, [property: JsonPropertyName("finish_reason")] string FinishReason, [property: JsonPropertyName("logprobs")] object Logprobs);

    public record Usage([property: JsonPropertyName("completion_tokens")] int CompletionTokens, [property: JsonPropertyName("prompt_tokens")] int PromptTokens, [property: JsonPropertyName("total_tokens")] int TotalTokens);
    public record DavinciCompletionResponse([property: JsonPropertyName("id")] string Id, [property: JsonPropertyName("object")] string Object, [property: JsonPropertyName("created")] int Created, [property: JsonPropertyName("model")] string Model, [property: JsonPropertyName("choices")] Choice[] Choices, [property: JsonPropertyName("usage")] Usage Usage);
}
