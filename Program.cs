var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSignalR().AddAzureSignalR("https://verona-signals.service.signalr.net;AccessKey=7KxJZZnIkHV2B5M7YQQhl9Xz0taGwDktDbzuWSZl1JU=;Version=1.0");
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.MapHub<SignalrHub>("/verona");
app.Run();