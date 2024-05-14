using Core;
using Core.Models;
using ServerAPI.Repositories;
using ServerAPI.Repositories.Interfaces;
namespace ServerAPI
{
	public class Program
	{
		private static List<Child> children = new List<Child>()
		{
            //Vi har fjernet alle Child.ID //Marcus og Hudayfa
            new Child(){ChildName = "Frederik", ChildAge = 4, BeenHereBefore = false, Comment = "Han er lidt speciel", Interests = "Han elsker bare biler og dinosaurere", TshirtSize = "Large"},
			new Child()
	{

		ChildName = "Frederik",
		ChildAge = 4,
		BeenHereBefore = false,
		Comment = "Han er lidt speciel",
		Interests = "Han elsker bare biler og dinosaurere",
		TshirtSize = "Large"
	},
	new Child()
	{

		ChildName = "Sofia",
		ChildAge = 6,
		BeenHereBefore = true,
		Comment = "Meget aktiv",
		Interests = "Tegning og dans",
		TshirtSize = "Medium"
	},
	new Child()
	{

		ChildName = "Emil",
		ChildAge = 5,
		BeenHereBefore = false,
		Comment = "Bliver let distraheret",
		Interests = "Legoklodser",
		TshirtSize = "Small"
	},
	new Child()
	{

		ChildName = "Liam",
		ChildAge = 7,
		BeenHereBefore = true,
		Comment = "En rigtig joker",
		Interests = "Videospil",
		TshirtSize = "Large"
	},
	new Child()
	{

		ChildName = "Olivia",
		ChildAge = 4,
		BeenHereBefore = true,
		Comment = "Vild med prinsesser",
		Interests = "Eventyrbøger",
		TshirtSize = "Small"
	},
	new Child()
	{

		ChildName = "Lucas",
		ChildAge = 6,
		BeenHereBefore = false,
		Comment = "Elsker sport",
		Interests = "Fodbold og basketball",
		TshirtSize = "Medium"
	},
	new Child()
	{

		ChildName = "Emma",
		ChildAge = 7,
		BeenHereBefore = true,
		Comment = "Utrolig social",
		Interests = "Venner og musik",
		TshirtSize = "Medium"
	},
	new Child()
	{

		ChildName = "Noah",
		ChildAge = 5,
		BeenHereBefore = true,
		Comment = "Kan lide at lege med dyr",
		Interests = "Dyr og zoologi",
		TshirtSize = "Medium"
	},
	new Child()
	{

		ChildName = "Ava",
		ChildAge = 6,
		BeenHereBefore = false,
		Comment = "Elsker maling og kunst",
		Interests = "Maleri og kunstprojekter",
		TshirtSize = "Large"
	},
	new Child()
	{

		ChildName = "William",
		ChildAge = 4,
		BeenHereBefore = false,
		Comment = "Er stille og rolig",
		Interests = "Puslespil og stille leg",
		TshirtSize = "Small"
	}
		};
		private static List<Parent> parents = new List<Parent>()
		{
            //Vi (Markus og Hudayfa) har fjernet ParentId
        new Parent(){ParentName = "Lars", ParentMail = "Lars@gmail.com", KræwNumber = 123, Children = new List<Child>{children[0],children[1]} },
		new Parent(){ParentName = "Mette", ParentMail = "Mette@gmail.com", KræwNumber = 145, Children = new List<Child>{children[2]} },
		new Parent(){ParentName = "Hans", ParentMail = "Hans@gmail.com", KræwNumber = 345, Children = new List<Child>{children[3],children[4]} },
		new Parent(){ParentName = "Dorte", ParentMail = "Dorte@gmail.com", KræwNumber = 112, Children = new List<Child>{children[5],children[6]} },
		new Parent(){ParentName = "Hanne", ParentMail = "Hanne@gmail.com", KræwNumber = 993, Children = new List<Child>{children[7],children[8]} },
		new Parent(){ParentName = "Jørgen", ParentMail = "Jørgen@gmail.com", KræwNumber = 333, Children = new List<Child>{children[9]} }

		};

		private static List<Event> Events = new List<Event>()
		{
			new Event(){EventID = 1, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "27", Workdays = "Onsdag - Søndag (Hel Uge)"},
			new Event(){EventID = 2, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "27", Workdays = "Onsdag - Fredag (Halv Uge)"},
			new Event(){EventID = 3, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "27", Workdays = "Lørdag - Søndag (Weekend)"},
			new Event(){EventID = 4, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "28", Workdays = "Onsdag - Søndag (Hel Uge)"},
			new Event(){EventID = 5, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "28", Workdays = "Onsdag - Fredag (Halv Uge)"},
			new Event(){EventID = 6, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "28", Workdays = "Lørdag - Søndag (Weekend)"},
			new Event(){EventID = 7, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "30", Workdays = "Onsdag - Søndag (Hel Uge)"},
			new Event(){EventID = 8, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "30", Workdays = "Onsdag - Fredag (Halv Uge)"},
			new Event(){EventID = 9, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "30", Workdays = "Lørdag - Søndag (Weekend)"},
			new Event(){EventID = 10, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "31", Workdays = "Onsdag - Søndag (Hel Uge)"},
			new Event(){EventID = 11, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "31", Workdays = "Onsdag - Fredag (Halv Uge)"},
			new Event(){EventID = 12, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "31", Workdays = "Lørdag - Søndag (Weekend)"},

		};

		private static List<Application> applications = new List<Application>()
		{
			new Application() {ApplicationID = 1, SubmitDate = DateTime.Now, Parent = parents[0], IsOnWaitingList = true, Priority1 = Events[0], Priority2 = Events[2]},
			new Application() {ApplicationID = 2, SubmitDate = DateTime.Now, Parent = parents[1], IsOnWaitingList = true, Priority1 = Events[0], Priority2 = Events[3]},
			new Application() {ApplicationID = 3, SubmitDate = DateTime.Now, Parent = parents[2], IsOnWaitingList = false, Priority1 = Events[3], Priority2 = Events[1]},
			new Application() {ApplicationID = 4, SubmitDate = DateTime.Now, Parent = parents[3], IsOnWaitingList = false, Priority1 = Events[1], Priority2 = Events[0]}

		};
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
