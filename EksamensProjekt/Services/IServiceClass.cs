using System;
using Core.Models;
namespace EksamensProjekt.Services
{
	public interface IServiceClass
	{
		Task<Application[]> GetAllApplications();

		Task AddApplication(Application application);

		Task AddParent(Parent parent);

		Task<Event[]> GetAllEvents();
	}
}