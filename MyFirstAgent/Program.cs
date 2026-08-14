using Microsoft.SemanticKernel;

var apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY") ?? throw new ArgumentException("GROQ_API_KEY environment variable is not set.");

var builder = Kernel.CreateBuilder();

builder.AddOpenAIChatCompletion(
    modelId: "llama-3.3-70b-versatile",
    apiKey: apiKey,
    endpoint: new Uri("https://api.groq.com/openai/v1")
    );

var kernel = builder.Build();

var result = await kernel.InvokePromptAsync("Hey, What is the capital of France?");

Console.WriteLine(result);