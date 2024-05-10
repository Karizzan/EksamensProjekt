using EksamensProjekt.Services;
using Core.Models;
namespace EksamensProjekt.Services
{
    public class ServiceClassInMemory : IServiceClass
    {
        private static List<Child> children = new List<Child>()
        {
            new Child(){ChildID = 1, ChildName = "Frederik", ChildAge = 4, BeenHereBefore = false, Comment = "Han er lidt speciel", Interests = "Han elsker bare biler og dinosaurere", TshirtSize = "Large"},
            new Child()
    {
        ChildID = 1,
        ChildName = "Frederik",
        ChildAge = 4,
        BeenHereBefore = false,
        Comment = "Han er lidt speciel",
        Interests = "Han elsker bare biler og dinosaurere",
        TshirtSize = "Large"
    },
    new Child()
    {
        ChildID = 2,
        ChildName = "Sofia",
        ChildAge = 6,
        BeenHereBefore = true,
        Comment = "Meget aktiv",
        Interests = "Tegning og dans",
        TshirtSize = "Medium"
    },
    new Child()
    {
        ChildID = 3,
        ChildName = "Emil",
        ChildAge = 5,
        BeenHereBefore = false,
        Comment = "Bliver let distraheret",
        Interests = "Legoklodser",
        TshirtSize = "Small"
    },
    new Child()
    {
        ChildID = 4,
        ChildName = "Liam",
        ChildAge = 7,
        BeenHereBefore = true,
        Comment = "En rigtig joker",
        Interests = "Videospil",
        TshirtSize = "Large"
    },
    new Child()
    {
        ChildID = 5,
        ChildName = "Olivia",
        ChildAge = 4,
        BeenHereBefore = true,
        Comment = "Vild med prinsesser",
        Interests = "Eventyrbøger",
        TshirtSize = "Small"
    },
    new Child()
    {
        ChildID = 6,
        ChildName = "Lucas",
        ChildAge = 6,
        BeenHereBefore = false,
        Comment = "Elsker sport",
        Interests = "Fodbold og basketball",
        TshirtSize = "Medium"
    },
    new Child()
    {
        ChildID = 7,
        ChildName = "Emma",
        ChildAge = 7,
        BeenHereBefore = true,
        Comment = "Utrolig social",
        Interests = "Venner og musik",
        TshirtSize = "Medium"
    },
    new Child()
    {
        ChildID = 8,
        ChildName = "Noah",
        ChildAge = 5,
        BeenHereBefore = true,
        Comment = "Kan lide at lege med dyr",
        Interests = "Dyr og zoologi",
        TshirtSize = "Medium"
    },
    new Child()
    {
        ChildID = 9,
        ChildName = "Ava",
        ChildAge = 6,
        BeenHereBefore = false,
        Comment = "Elsker maling og kunst",
        Interests = "Maleri og kunstprojekter",
        TshirtSize = "Large"
    },
    new Child()
    {
        ChildID = 10,
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
            new Parent(){ParentID = 1, ParentName = "Lars", ParentMail = "Lars@gmail.com", KræwNumber = 123, Children = new List<Child>{children[0],children[1]} },
        new Parent(){ParentID = 2, ParentName = "Mette", ParentMail = "Mette@gmail.com", KræwNumber = 145, Children = new List<Child>{children[2]} },
        new Parent(){ParentID = 3, ParentName = "Hans", ParentMail = "Hans@gmail.com", KræwNumber = 345, Children = new List<Child>{children[3],children[4]} },
        new Parent(){ParentID = 4, ParentName = "Dorte", ParentMail = "Dorte@gmail.com", KræwNumber = 112, Children = new List<Child>{children[5],children[6]} },
        new Parent(){ParentID = 5, ParentName = "Hanne", ParentMail = "Hanne@gmail.com", KræwNumber = 993, Children = new List<Child>{children[7],children[8]} },
        new Parent(){ParentID = 6, ParentName = "Jørgen", ParentMail = "Jørgen@gmail.com", KræwNumber = 333, Children = new List<Child>{children[9]} }

        };

        private static List<Event> Events = new List<Event>()
        {
            new Event(){EventID = 1, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "27"},
            new Event(){EventID = 2, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Balderup", WeekNumber = "28"},
            new Event(){EventID = 3, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "30"},
            new Event(){EventID = 4, StartDate = DateTime.Now, EndDate = DateTime.Now, Location = "Aarhus", WeekNumber = "31"},

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
