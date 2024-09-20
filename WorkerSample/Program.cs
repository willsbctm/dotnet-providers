using WorkerSample;

//appsettings.json.
//appsettings.{Environment}.json.
//Secret Manager when the app runs in the Development environment.
//Environment variables.
//Command-line arguments.

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();



// dotnet user-secrets init
