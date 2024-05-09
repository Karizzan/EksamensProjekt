using Core;
using ServerAPI.Repositories;
using ServerAPI.Repositories.Interfaces;
namespace ServerAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{



			var a = new AdminRepository();
			var b = new SignUpRepository();

          //  var admin = a.GetAdminByUsername("Seb8530");
          //  var signUp = b.GetSignUpByEmail("Elise@gmail.com");







			var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
            builder.Services.AddSingleton<ISignUpRepository, SignUpRepository>();
           
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("policy",
                                  policy =>
                                  {
                                      policy.AllowAnyOrigin();
                                      policy.AllowAnyMethod();
                                      policy.AllowAnyHeader();
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

			app.UseAuthorization();

            app.UseCors("policy");

            app.MapControllers();

			app.Run();
		}
	}
}
