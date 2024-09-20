// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

Console.WriteLine("Provedores de configuração");

//File Provider


//JSON
//Microsoft.Extensions.Configuration.Json
var jsonProvider = new ConfigurationBuilder();
jsonProvider.AddJsonFile("nossosettings.json");
var jsonConfig = jsonProvider.Build();

//Microsoft.Extensions.Configuration.Binder 
var valueFromJson = jsonConfig.GetValue<string>("value1");
Console.WriteLine(valueFromJson);



//XML
// Microsoft.Extensions.Configuration.Xml 
var xmlProvider = new ConfigurationBuilder();
xmlProvider.AddXmlFile("nossosettings.xml");
var xmlConfig = xmlProvider.Build();

var valueFromXml = xmlConfig.GetValue<string>("value1");
Console.WriteLine(valueFromXml);



//INI
//Microsoft.Extensions.Configuration.Ini 
var iniProvider = new ConfigurationBuilder();
iniProvider.AddIniFile("nossosettings.ini");
var iniConfig = iniProvider.Build();

var valueFromIni = iniConfig.GetValue<string>("value1");
Console.WriteLine(valueFromIni);



//ENVIRONMENT VARIABLE
//Microsoft.Extensions.Configuration.EnvironmentVariables 
var environmentProvider = new ConfigurationBuilder();
environmentProvider.AddEnvironmentVariables();
var environmentConfig = environmentProvider.Build();

var valueFromEnvironment = environmentConfig.GetValue<string>("value1");
Console.WriteLine(valueFromEnvironment);



//COMMAND LINE
//Microsoft.Extensions.Configuration.CommandLine 
var commandProvider = new ConfigurationBuilder();
commandProvider.AddCommandLine(args);
var commandConfig = commandProvider.Build();

var valueFromCommand = commandConfig.GetValue<string>("value1");
Console.WriteLine(valueFromCommand);


//KEY PER FILE
var keyProvider = new ConfigurationBuilder();
keyProvider.AddKeyPerFile(Path.Combine(Directory.GetCurrentDirectory(), "values"));
var keyConfig = keyProvider.Build();

var valueFromKey = keyConfig.GetValue<string>("value1");
Console.WriteLine(valueFromKey);



//IN MEMORY
var memoryProvider = new ConfigurationBuilder();
memoryProvider.AddInMemoryCollection([
    new KeyValuePair<string, string?>(key: "value1", "valor da memória")
]);
var memoryConfig = memoryProvider.Build();

var valueFromMemory = memoryConfig.GetValue<string>("value1");
Console.WriteLine(valueFromMemory);



//AZURE APP SERVICE

//CUSTOM

//SECRET


