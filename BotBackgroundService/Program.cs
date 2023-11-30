using BotBackgroundService.BackGroundService;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);
var token = builder.Configuration["token"];
builder.Services.AddSingleton(new TelegramBotClient(token));
builder.Services.AddHostedService<BotBackGroundService>();

var app = builder.Build();

app.Run();
