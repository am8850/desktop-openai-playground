using System.Text.Json;

namespace DavinciWF
{
    internal static class Program
    {
        internal const int Default_AI_Max_Tokens = 400;
        internal const double Default_AI_Temperature = 0.3;
        internal static Settings? AppSettings { get; set; }


        // One HttpClient Instance
        private static HttpClient client = new HttpClient();

        public static HttpClient Client { get => client; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            AppSettings = LoadEnvironment.Settings;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            client.Timeout = TimeSpan.FromMinutes(100);
            Client.DefaultRequestHeaders.Add("api-key", AppSettings.OPENAI_API_KEY);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        class LoadEnvironment
        {
            private LoadEnvironment()
            {
                
            }

            private static Settings settings { get; set; }
            
            public static Settings Settings
            {
                get
                {
                    if (settings is null)
                    {
                        var loadedSettings = JsonSerializer.Deserialize<Settings>(System.IO.File.ReadAllText(".env.json"));
                        settings = loadedSettings ?? new Settings("","","");
                    }
                    return settings;
                }
            }
        }

        public record Settings(string OPENAI_API_GPT_URI, string OPENAI_API_DAVINCI_URI, string OPENAI_API_KEY);
    }
}