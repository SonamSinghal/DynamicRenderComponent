using DataModel;

namespace DynamicRenderComponent.Server.Repository
{
    public interface IComponentRepository
    {
        void SaveChanges();
        Task SaveComponent(ComponentModel model);
        Task<List<ComponentModel>> GetAllComponentsAsync(string url);
    }
}