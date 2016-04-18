using uFrame.Attributes;

namespace uFrame.ECS
{
    
    public class ComponentDestroyedEvent
    {
        public IEcsComponent Component { get; set; }
    }
}