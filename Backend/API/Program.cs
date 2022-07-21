var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("", () => { });
app.MapPut("", () => { });
app.MapPost("", () => { });
app.MapDelete("", () => { });


app.Run();
