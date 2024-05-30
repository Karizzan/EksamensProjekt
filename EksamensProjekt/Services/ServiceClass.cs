using System.Net.Http.Json;
using Core.Models;


namespace EksamensProjekt.Services
{
    // The ServiceClass is used to handle all the requests that are made to the server
    public class ServiceClass : IServiceClass
    {
        // The http is used to make the requests to the server
        HttpClient http;

        // The serverUrl is used to define the url of the server
        private string serverUrl = "https://racerbanenserver.azurewebsites.net";

        // The constructor is used to set the http to the incoming http
        public ServiceClass(HttpClient http)
        {
            this.http = http;
        }

        // The GetAllApplications function is used to get all the applications from the database
        public async Task<Application[]> GetAllApplications()
        {
            var applications = await http.GetFromJsonAsync<Application[]>($"{serverUrl}/application/getAll");

            return applications.ToArray();

        }

        // The AddApplication function is used to add a new application to the database
        public async Task AddApplication(Application application)
        {
            await http.PostAsJsonAsync($"{serverUrl}/application/add", application);
        }

        //The UpdateApplication function is used to update an application in the database
        public async Task UpdateApplication(Application application)
        {
            await http.PutAsJsonAsync($"{serverUrl}/application/update", application);
        }

        //The DeleteApplicationByID function is used to remove an application from the database by the id
        public async Task DeleteApplicationByID(int id)
        {
            await http.DeleteAsync($"{serverUrl}/application/delete/{id}");
        }

        //The AddAdmin function is used to add a new admin to the database
        public async Task AddAdmin(Admin admin)
        {
            await http.PostAsJsonAsync($"{serverUrl}/admin/add/", admin);
        }

        // The DeleteAdminByID function is used to remove an admin from the database by the id
        public async Task DeleteAdminByID(int adminID)
        {
            await http.DeleteAsync($"{serverUrl}/admin/delete/{adminID}");
        }

        // The GetAllAdmins function is used to get all the admins from the database
        public async Task<Admin[]> GetAllAdmins()
        {
            var admins = await http.GetFromJsonAsync<Admin[]>($"{serverUrl}/admin/getAll");

            return admins.ToArray();

        }

        // The GetAllEvents function is used to get all the events from the database
        public async Task<Event[]> GetAllEvents()
        {
            var events = await http.GetFromJsonAsync<Event[]>($"{serverUrl}/event/getAll");
            return events.ToArray();

        }

        // The AddEvent function is used to add a new event to the database
        public async Task AddEvent(Event Event)
        {
            await http.PostAsJsonAsync<Event>($"{serverUrl}/event/add", Event);
        }

        // The UpdateEvent function is used to update an event in the database
        public async Task UpdateEvent(Event Event)
        {
            await http.PutAsJsonAsync($"{serverUrl}/event/update", Event);
        }

        // The RemoveEventByWeekNumber function is used to remove an event from the database by the week number
        public async Task RemoveEventByWeekNumber(int weekNumber)
        {
            await http.DeleteAsync($"{serverUrl}/event/delete/{weekNumber}");
            Console.WriteLine(weekNumber);
            Console.WriteLine("heeey");
        }


        //The GetAllYoungApplications function is used to get all the young applications from the database
        public async Task<YoungApplication[]> GetAllYoungApplications()
        {
            var youngApplications = await http.GetFromJsonAsync<YoungApplication[]>($"{serverUrl}/application/getAllYoung");
            return youngApplications;
        }

        // The AddYoungApplication function is used to add a new young application to the database
        public async Task AddYoungApplication(YoungApplication application)
        {
            await http.PostAsJsonAsync($"{serverUrl}/application/addYoung", application);
        }

        //The UpdateYoungApplication function is used to update a young application in the database
        public async Task UpdateYoungApplication(YoungApplication application)
        {
            await http.PutAsJsonAsync($"{serverUrl}/application/update", application);
        }

        //The DeleteYoungApplicationByID function is used to remove a young application from the database by the id
        public async Task DeleteYoungApplicationByID(int id)
        {
            await http.DeleteAsync($"{serverUrl}/application/delete/{id}");
        }

        //The GetAllLegacyApplication function is used to get all the legacy applications from the database
        public async Task<Application[]> GetAllLegacyApplication()
        {
            var applications = await http.GetFromJsonAsync<Application[]>($"{serverUrl}/application/getalllegacy");
            return applications.ToArray();
        }

        public async Task AddParentChild(Parent parentChild)
        {
            await http.PostAsJsonAsync($"{serverUrl}/parentchild/add", parentChild);
        }
    }

}









