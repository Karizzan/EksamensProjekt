using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
	// The IApplicationRepository is used to define the functions that the ApplicationRepository must implement
	public interface IApplicationRepository
	{
		// The GetAllApplications function is used to get all the applications from the database
		public List<Application> GetAllApplications();

		// The AddApplication function is used to add a new application to the database
		public void AddApplication(Application application);

		// The RemoveApplicationByID function is used to remove an application from the database by the id
		public void RemoveApplicationByID(int id);

		// The UpdateApplication function is used to update an application in the database
		public List<YoungApplication> GetAllYoungApplications();

		// The AddYoungApplication function is used to add a new young application to the database
		public void AddYoungApplication(YoungApplication youngApplication);

		// The RemoveYoungApplicationByID function is used to remove a young application from the database by the id
		public void RemoveYoungApplicationByID(int youngApplicationId);

		// The UpdateYoungApplication function is used to update a young application in the database
		public void UpdateApplication(Application application);

		// The GetAllYoungApplications function is used to get all the young applications from the database
		public void UpdateYoungApplication(YoungApplication youngApplication);

		// The GetAllLegacyApplication function is used to get all the legacy applications from the database
		public List<Application> GetAllLegacyApplication();


	}
}
