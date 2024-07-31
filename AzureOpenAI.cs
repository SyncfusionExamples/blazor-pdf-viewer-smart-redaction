using Azure.AI.OpenAI;
using Azure;
using SmartComponents.LocalEmbeddings;
using System.Text;

namespace PdfViewerSmartRedaction
{

    public class AzureOpenAI
    {
        public Dictionary<string, EmbeddingF32> PageEmbeddings { get; set; }

        const string endpoint = "YOUR-AZURE-OPENAI-URL";
        const string deploymentName = "DEPLOYMENT-NAME";

        string key = "";

        public AzureOpenAI(string key)
        {
            this.key = key;
        }

        /// <summary>
        /// Initialize local embeddings for the provided text chunks
        /// </summary>
        /// <param name="chunks"></param>
        /// <returns></returns>
        public async Task Initialize(string[] chunks)
        {

            var embedder = new LocalEmbedder();
            PageEmbeddings = chunks.Select(x => KeyValuePair.Create(x, embedder.Embed(x))).ToDictionary(k => k.Key, v => v.Value);
        }

        /// <summary>
        /// Get answer from GPT-4o
        /// </summary>
        /// <param name="systemPrompt"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<string> GetAnswerFromGPT(string userPrompt)
        {
            var client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(key));

            var chatCompletionsOptions = new ChatCompletionsOptions
            {
                DeploymentName = deploymentName,
                Temperature = (float)0.5,
                MaxTokens = 800,
                NucleusSamplingFactor = (float)0.95,
                FrequencyPenalty = 0,
                PresencePenalty = 0,
            };

            // Get the first 10 keys from PageEmbeddings and join them into a single string
            List<string> message = PageEmbeddings.Keys.Take(10).ToList();
            string contextData = String.Join(" ", message);

            // Add the system message and user message to the options
            chatCompletionsOptions.Messages.Add(new ChatRequestSystemMessage(contextData));
            chatCompletionsOptions.Messages.Add(new ChatRequestUserMessage(userPrompt));

            var response = await client.GetChatCompletionsAsync(chatCompletionsOptions);

            return response.Value.Choices[0].Message.Content;
        }
    }

}

