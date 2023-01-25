using AskLearn;
using AskLearn.Services;
using OpenAI.GPT3.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "your openAI key");
        //services.AddHostedService<OpenAICompletionService>();
        services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();