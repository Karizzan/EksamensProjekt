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

		public async Task<Event[]> GetAllEvents()
		{
			var events = await http.GetFromJsonAsync<Event[]>($"{serverUrl}/event/getAll");
			return events.ToArray();

		}

		public async Task AddEvent(Event Event){
			await http.PostAsJsonAsync<Event>($"{serverUrl}/event/add",Event);
		}

		public async Task UpdateEvent(Event Event)
		{
			await http.PutAsJsonAsync($"{serverUrl}/event/update", Event);
		}
	}
}
