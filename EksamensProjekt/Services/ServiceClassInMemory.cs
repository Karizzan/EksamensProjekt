using EksamensProjekt.Services;
using Core.Models;
namespace EksamensProjekt.Services
{
    public class ServiceClassInMemory : IServiceClass
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

        public ServiceClassInMemory() { }

        public Task AddApplication(Application application)
        {
            Task t = new Task(() => applications.Add(application));
            t.Start();
            return t;
        }

        public Task<Application[]> GetAllApplications()
        {
            Task<Application[]> t = new Task<Application[]>(() => applications.ToArray());

            t.Start();
            return t;
        }

        public Task AddParent(Parent parent)
        {
            Task t = new Task(() => parents.Add(parent));
            t.Start();
            return t;
        }


		public Task<Event[]> GetAllEvents()
		{
			Task<Event[]> t = new Task<Event[]>(() => Events.ToArray());

			t.Start();
			return t;
		}


	}
}
