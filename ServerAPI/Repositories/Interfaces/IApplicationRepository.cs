using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    public interface IApplicationRepository
    {
       public List<Application> GetAllApplications();
       public void AddApplication(Application application);
       public void RemoveApplicationByID(int id);
		public List<YoungApplication> GetAllYoungApplications();
		public void AddYoungApplication(YoungApplication youngApplication);
		public void RemoveYoungApplicationByID(int youngApplicationId);
        
        public void UpdateApplication(Application application);
        public void UpdateYoungApplication(YoungApplication youngApplication);
        public List<Application> GetAllLegacyApplication();
       
        
	}
}
