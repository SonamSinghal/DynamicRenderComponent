using DataModel;

namespace DynamicRenderComponent.Services
{
    public interface IComponentService
    {
        Task<HttpResponseMessage> PostComponent(ComponentModel model);
        Task<List<ComponentModel>> GetAllComponentsAsync(string url);
    }
}