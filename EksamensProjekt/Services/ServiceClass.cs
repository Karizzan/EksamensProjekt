using System.Net.Http.Json;
using Core.Models;


namespace EksamensProjekt.Services
{
	public class ServiceClass : IServiceClass
	{
		HttpClient http;

		// adresse på server
		private string serverUrl = "https://localhost:7270";


		public ServiceClass(HttpClient http)
		{
			this.http = http;
		}

		public async Task<Application[]> GetAllApplications()
		{
			var applications = await http.GetFromJsonAsync<Application[]>($"{serverUrl}/application/getAll");

			return applications.ToArray();

		}

		public async Task AddApplication(Application application)
		{
			await http.PostAsJsonAsync($"{serverUrl}/application/add", application);
		}

		public async Task UpdateApplication (Application application)
		{
			await http.PutAsJsonAsync($"{serverUrl}/application/update", application );
		}

		public async Task DeleteApplicationByID(int id)
		{
			await http.DeleteAsync($"{serverUrl}/application/delete/{id}");
		}

		public async Task AddAdmin(Admin admin)
		{
			await http.PostAsJsonAsync($"{serverUrl}/admin/add/", admin);
		}

		public async Task DeleteAdminByID(int adminID)
		{
			await http.DeleteAsync($"{serverUrl}/admin/delete/{adminID}");
		}

		public async Task<Admin[]> GetAllAdmins()
		{
			var admins = await http.GetFromJsonAsync<Admin[]>($"{serverUrl}/admin/getAll");

			return admins.ToArray();

		}

		public async Task<Event[]> GetAllEvents()
		{
			var events = await http.GetFromJsonAsync<Event[]>($"{serverUrl}/event/getAll");
			return events.ToArray();

		}

		public async Task AddEvent(Event Event)
		{
			await http.PostAsJsonAsync<Event>($"{serverUrl}/event/add", Event);
		}

		public async Task UpdateEvent(Event Event)
		{
			await http.PutAsJsonAsync($"{serverUrl}/event/update", Event);
		}

        public bool CheckLogin(string username, string password)
        {
			//await http.GetFromJsonAsync<Admin>($"{serverUrl}/admin/checklogin");

			// Send a GET request to the server to check login
			//HttpResponseMessage response = await http.GetAsync($"{serverUrl}/admin/checklogin?username={username}&password={password}");

			return true;
		}
        public async Task AddYoungApplication(YoungApplication application)
        {
            await http.PostAsJsonAsync($"{serverUrl}/application/addYoung/", application);
        }


    }
}



