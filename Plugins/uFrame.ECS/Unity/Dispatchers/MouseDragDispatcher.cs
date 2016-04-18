using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Mouse Drag"), uFrameCategory("Unity Messages")]
    public class MouseDragDispatcher : EcsDispatcher
    {
        public void OnMouseDrag()
        {
            Publish(this);
        }
    }
}