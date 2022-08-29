using DataModel;
using DynamicRenderComponent.Server.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicRenderComponent.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ComponentController : ControllerBase
    {
        private readonly IComponentRepository _componentRepository;
        public ComponentController(IComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }

        [HttpPost("saveComponents")]
        public async Task SaveComponents(ComponentModel model)
        {
            await _componentRepository.SaveComponent(model);
        }

    }
}
