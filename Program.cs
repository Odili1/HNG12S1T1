using HNG12S1T1.Services;

var builder = WebApplication.CreateBuilder(args);



// Services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddHttpClient();
//builder.Services.AddMvc();
builder.Services.AddScoped<NumberService>();
builder.Services.AddControllers();

var app = builder.Build();



app.UseCors("AllowAll");
app.MapControllers();
app.Run();
