using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using MyFirstAgent;

var apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY") ?? throw new ArgumentException("GROQ_API_KEY environment variable is not set.");

var builder = Kernel.CreateBuilder();

builder.AddOpenAIChatCompletion(
    modelId: "openai/gpt-oss-120b",
    apiKey: apiKey,
    endpoint: new Uri("https://api.groq.com/openai/v1")
    );

builder.Plugins.AddFromType<BookStoreTools>();

var kernel = builder.Build();

//var result = await kernel.InvokePromptAsync("Hey, What is the capital of France?");

var settings = new OpenAIPromptExecutionSettings
{
    ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
};

var result = await kernel.InvokePromptAsync("What is the final price of 'The Trial' after a 10% discount?", new(settings));

Console.WriteLine(result);