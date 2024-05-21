using Core;
using Core.Models;
using ServerAPI.Repositories;
using ServerAPI.Repositories.Interfaces;
namespace ServerAPI
{
	public class Program
	{
		//private static List<Child> children = new List<Child>()
	
		public static void Main(string[] args)
		{




			var a = new AdminRepository();
			var b = new ApplicationRepository();
			var c = new EventRepository();
			var d = new ParentChildRepository();
	
			
		/*	foreach (var item in parents)
			{
				d.AddParentChild(item);
			}
			foreach (var item in applications)
			{
				b.AddApplication(item);
			}
			
			foreach (var item in Events)
			{
				c.AddEvent(item);
			}*/
			


			//  var admin = a.GetAdminByUsername("Seb8530");
			//  var signUp = b.GetSignUpByEmail("Elise@gmail.com");







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

		

			app.UseHttpsRedirection();

			app.UseAuthorization();

            app.UseCors("policy");

            app.MapControllers();

			app.Run();
		}
	}
}
