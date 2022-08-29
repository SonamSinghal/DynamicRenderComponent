using DataModel;
using DataModel.Data;

namespace DynamicRenderComponent.Server.Repository
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ApplicationDbContext _context;

        public ComponentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveComponent(ComponentModel model)
        {
            try
            {
                var component = new ComponentModel()
                {
                    ComponentName = model.ComponentName,
                    Zone = model.Zone,
                    CreatedOn = model.CreatedOn,
                    PageUrl = model.PageUrl,
                    Sequence = model.Sequence,

                };
                var id = await _context.Components.AddAsync(component);
                component.Id = component.Id;
                SaveChanges();
                var id1 = component.Id;
            }
            catch (Exception e)
            {
                var exc = e;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
