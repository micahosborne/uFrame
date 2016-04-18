using uFrame.Attributes;

namespace uFrame.ECS
{
    
    public class ComponentCreatedEvent
    {
        public IEcsComponent Component { get; set; }
    }
}