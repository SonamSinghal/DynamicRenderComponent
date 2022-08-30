using DataModel;

namespace DynamicRenderComponent.Services
{
    public class ComponentService : IComponentService
    {
        private readonly HttpClient _httpClient;

        public ComponentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> PostComponent(ComponentModel model)
        {
            var response = await _httpClient.PostAsJsonAsync<ComponentModel>("Component/saveComponents", model);
            return response;
        }

        public async Task<List<ComponentModel>> GetAllComponentsAsync(string url)
        {
            var data = await _httpClient.GetFromJsonAsync<List<ComponentModel>>($"Component/getComponents?url={url}");
            return data;
        }
    }
}
