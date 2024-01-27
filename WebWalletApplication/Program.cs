
using Microsoft.Identity.Client;
using WalletDalContract;
using WalletFuncLogic;
using WalletFuncLogicContracts;
using WalletRepositories;


namespace WebWalletApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Add services to the container.

             
                var builder = WebApplication.CreateBuilder(args);
                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
                builder.Services.AddScoped<IWalletLogic, WalletLogic>();
                builder.Services.AddScoped<IWalletRepository, WalletRepository>();

                var app = builder.Build();


                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            
            }
        }
    
}
