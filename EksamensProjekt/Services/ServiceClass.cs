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

		public async Task AddAdmin(Admin admin)
		{
			await http.PostAsJsonAsync($"{serverUrl}/admin/add/", admin);
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

		public async Task<bool> CheckLogin(string username, string password)
		{
			// Send a GET request to the server to check login
			HttpResponseMessage response = await http.GetAsync($"{serverUrl}/admin/checklogin?username={username}&password={password}");

			// Check if the response indicates success (200 OK)
			if (response.IsSuccessStatusCode)
			{
				// Read the content of the response
				string responseContent = await response.Content.ReadAsStringAsync();

				// Parse the response content to interpret the result
				// Assuming the response content is a boolean indicating login success
				bool isAuthenticated = bool.Parse(responseContent);

				return isAuthenticated;
			}
			else
			{
				// If the request fails (e.g., server error), return false
				return false;
			}
		}
	}



}



