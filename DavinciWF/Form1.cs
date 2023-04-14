using DavinciWF.models;
using DavinciWF.services;
using System.Text.Json;

namespace DavinciWF
{
    public partial class Form1 : Form
    {
        IOpenAIService service;
        private Color bgColor;

        public Form1()
        {
            InitializeComponent();
            bgColor = txtContext.BackColor;
            lblPrompTokens.Text = string.Empty;
            lblCompletionTokens.Text = string.Empty;
            txtMaxTokens.Text = Program.Default_AI_Max_Tokens.ToString();
            txtTemperature.Text = Program.Default_AI_Temperature.ToString();
            service = new OpenAIService(Program.Client);
        }

        private void ResetFields(bool resetContext = true)
        {
            if (resetContext)
            {
                txtContext.Text = string.Empty;
            }
            txtPrompt.Text = string.Empty;
            txtMaxTokens.Text = Program.Default_AI_Max_Tokens.ToString();
            txtTemperature.Text = Program.Default_AI_Temperature.ToString();
            txtN.Text = "1";
            txtCompletion.Text = string.Empty;
            txtFullPrompt.Text = string.Empty;
            lblCompletionTokens.Text = string.Empty;
            lblPrompTokens.Text = string.Empty;
            chkSensitive.Checked = false;
            txtContext.BackColor = bgColor;
            txtContext.Text = string.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var prompt = txtPrompt.Text;
            var context = txtContext.Text;
            var max_tokens = int.Parse(txtMaxTokens.Text);
            var temperature = double.Parse(txtTemperature.Text);
            var n = int.Parse(txtN.Text);

            button1.Enabled = false;

            if (chkGPT.Checked)
            {
                var messages = new List<GptMessage>();
                if (!string.IsNullOrEmpty(context))
                    messages.Add(new GptMessage("system", $"You are an assistant that can respond to questions based on the following context:\n{context}"));
                else
                    messages.Add(new GptMessage("system", $"You are a general assitant."));
                messages.Add(new GptMessage("user", $"{prompt}"));

                var request = new GptPromptRequest(messages.ToArray());
                var json = JsonSerializer.Serialize(request);

                DetermineSensitivity(json);

                GptCompletionResponse? completion = null;
                try
                {
                    completion = await service.Chat(request);
                }
                catch (Exception ex)
                {

                    txtCompletion.Text = ex.ToString();
                }
                finally
                {
                    txtCompletion.Text = completion?.choices[0].message.content;
                    lblCompletionTokens.Text = completion?.usage.completion_tokens.ToString();
                    lblPrompTokens.Text = completion?.usage.prompt_tokens.ToString();
                    button1.Enabled = true;
                }

            }
            else
            {
                // Build prompt
                string? fullPrompt;
                if (!string.IsNullOrEmpty(context))
                    fullPrompt = prompt + "[context]\n" + context;
                else
                    fullPrompt = prompt;

                // Build request
                var request = new DavinciPromptRequest(fullPrompt, max_tokens, temperature, n);
                var json = JsonSerializer.Serialize(request);

                // Show the payload if not sensitive
                DetermineSensitivity(json);

                // Execute the request
                DavinciCompletionResponse? resp = null;
                try
                {
                    resp = await service.Prompt(request);
                }
                catch (Exception ex)
                {

                    txtCompletion.Text = ex.ToString();
                }
                finally
                {
                    txtCompletion.Text = resp?.Choices[0].Text;
                    lblCompletionTokens.Text = resp?.Usage.CompletionTokens.ToString();
                    lblPrompTokens.Text = resp?.Usage.PromptTokens.ToString();
                    button1.Enabled = true;
                }
            }

        }

        private void DetermineSensitivity(string json)
        {
            if (!chkSensitive.Checked)
                txtFullPrompt.Text = json;
            else
                txtFullPrompt.Text = "Sensitive information.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetFields(false);
            button1.Enabled = true;
        }

        private void ChkSensitive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSensitive.Checked)
                txtContext.BackColor = Color.Black;
            else
                txtContext.BackColor = bgColor;
        }
    }
}