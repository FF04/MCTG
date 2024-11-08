
using MCTG.Services;

namespace MCTG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
#warning toadd classdiagram
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IUserService, UserService>();

            var app = builder.Build();

            // Add this service so it can be used in controllers
            var userService = app.Services.GetRequiredService<IUserService>() as UserService;
#warning to verknüpfen
            //    userService?.InitializeData(); // Load Start Data


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
