using Core.Models;
namespace ServerAPI.Repositories.Interfaces
{
    // The IParentChildRepository is used to define the functions that the ParentChildRepository must implement
    public interface IParentChildRepository
    {
        // The GetAllParentChilds function is used to get all the parentchilds from the database
        public List<Parent> GetAllParentChilds();

        // The AddParentChild function is used to add a new parentchild to the database
        public void AddParentChild(Parent parentchild);

        // The RemoveParentChildByID function is used to remove a parentchild from the database by the id
        public void RemoveParentChildnByMail(string parentmail);
    }
}
