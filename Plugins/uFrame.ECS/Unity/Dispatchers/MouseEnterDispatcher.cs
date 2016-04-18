using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Mouse Enter"), uFrameCategory("Unity Messages")]
    public class MouseEnterDispatcher : EcsDispatcher
    {
        public void OnMouseEnter()
        {
            Publish(this);
        }
    }
}