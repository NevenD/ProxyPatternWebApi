using ProxyPatternWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// in our scenario we used singleton becuase we want life of the services to be live during the lifetime of the app
// we are sharing state through the app
// if wea re using httpcontext, or similar we should use scoped or transient
// for example if we are using services such as IUserService or IHttpContextAccessor then we should not use singleton
builder.Services.AddSingleton<RealWeatherService>();
builder.Services.AddSingleton<IWeatherService>(provider =>
    new WeatherServiceProxy(provider.GetRequiredService<RealWeatherService>()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.MapGet("/weather/{city}", async (string city, IWeatherService service) =>
{
    var result = await service.GetWeatherAsync(city);
    return Results.Ok(result);
});

app.UseHttpsRedirection();



app.Run();

