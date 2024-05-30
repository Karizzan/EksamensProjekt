using Core;
using Core.Models;
using ServerAPI.Repositories;
using ServerAPI.Repositories.Interfaces;
namespace ServerAPI
{
	public class Program
	{

		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
			builder.Services.AddSingleton<IApplicationRepository, ApplicationRepository>();
			builder.Services.AddSingleton<IParentChildRepository, ParentChildRepository>();
			builder.Services.AddSingleton<IEventRepository, EventRepository>();



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

			app.UseAuthentication();

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.UseCors("policy");

			app.MapControllers();

			app.Run();
		}
	}
}
