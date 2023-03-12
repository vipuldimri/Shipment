using Application.Abstractions;
using Infrastructure.External;
using Infrastructure.Persistence.Dapper;
using Application;
using Infrastructure.Persistence.Dapper.SQLServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<IQuoteService, QuoteService>(httpclient =>
                            {
                                httpclient.BaseAddress = new Uri("https://api.quotable.io");
                            }).SetHandlerLifetime(TimeSpan.FromMinutes(5));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

//Dapper config
var connectionString = builder.Configuration.GetConnectionString("sqlConnection");
Action<DapperDatabaseOptions> dapperOptions = options =>
{
    options.ConnectionString = connectionString;
};

builder.Services.Configure(dapperOptions);
builder.Services.AddScoped<IApplicationRepositoryManager, DapperRepositoryManager>();
builder.Services.AddSingleton<IDatabaseConnectionFactory, SQLServerConnectionFactory>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllAllowed",
                      builder =>
                      {
                          builder.WithOrigins("*");
                      });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors("AllAllowed");

app.UseAuthorization();


app.MapControllers();

app.Run();
