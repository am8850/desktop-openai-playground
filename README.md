# desktop-openai-playground
A Windows forms .net 7 app to prompt and set context in Azure OpenAI Davinci and GPT endpoints

## Setup

- Create a file `env.json` with the following settings:
```json
{
  "OPENAI_API_GPT_URI": "https://<name>.openai.azure.com/openai/deployments/gpt/<gpt-deployment-name>/completions?api-version=2023-03-15-preview",
  "OPENAI_API_DAVINCI_URI": "https://<name>.openai.azure.com/openai/deployments/<davinci-deployment-name>/completions?api-version=2022-12-01",
  "OPENAI_API_KEY": "<KEY>"
}
```

- In Visual Studio, click on the new file
- Look for the Properties tab
- Change the Build Action to: Copy always