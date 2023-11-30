using BotBackgroundService.Service;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BotBackgroundService.BackGroundService;

public class BotBackGroundService : BackgroundService
{
    private readonly TelegramBotClient _botClient;

    public BotBackGroundService(TelegramBotClient botClient)
       => _botClient = botClient; 
   
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Botimiz eshitishni boshladi");

        _botClient.StartReceiving<UpdateHandlerService>(null, stoppingToken);
        return Task.CompletedTask;
    }
}
