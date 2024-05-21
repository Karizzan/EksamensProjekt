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
			await http.PostAsJsonAsync($"{serverUrl}/application/add/", application);
		}

		public async Task<Event[]> GetAllEvents()
		{
			var events = await http.GetFromJsonAsync<Event[]>($"{serverUrl}/event/getAll");

			return events.ToArray();

		}
        public async Task AddYoungApplication(YoungApplication application)
        {
            await http.PostAsJsonAsync($"{serverUrl}/application/addYoung/", application);
        }


    }
}
