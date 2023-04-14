namespace DavinciWF.models
{
    //{
    //    public int index { get; init; }
    //    public string finish_reason { get; init; }
    //    public GptMessage message { get; init; }
    //}

    internal record GptMessage(string role, string content);
    //{
    //    public int completion_tokens { get; init; }
    //    public int prompt_tokens { get; init; }
    //    public int total_tokens { get; init; }
    //}

}
