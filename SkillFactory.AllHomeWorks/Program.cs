using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using SkillFactory.AllHomeWorks;
using SkillFactory.AllHomeWorks.Configuration;
using SkillFactory.AllHomeWorks.Contollers;
using Telegram.Bot;



var host = new HostBuilder().ConfigureServices((hostContext, services)=>
ConfigureServices(services)).UseConsoleLifetime().Build();

await host.RunAsync();  
    
  void ConfigureServices(IServiceCollection services)
{
    AppSettings appSettings = BuildAppSettings();

    services.AddTransient<DefaultMessageContoller>();
    services.AddTransient<TextMessageController>();
  

    services.AddSingleton(BuildAppSettings());
    services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient(appSettings.BotToken));

    services.AddHostedService<Bot>();
}


AppSettings BuildAppSettings()
{

    return new AppSettings()
    {
        BotToken = "6973668228:AAGxqgzMGvhUz7ZTJN1iQVQXHzIWLPNfKEw"
    }; 

}