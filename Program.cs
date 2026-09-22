var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.MapGet("/", () => "Change in the configuration file 22-9-2027");
app.Run();
