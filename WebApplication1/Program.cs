using System.Dynamic;
using WebApplication1;



public class Program
{
    static void Main(String[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    static IHostBuilder CreateHostBuilder(string[] args)
    {

        return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }

}


/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.



*/
