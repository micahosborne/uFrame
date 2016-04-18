using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Mouse Down"), uFrameCategory("Unity Messages")]
    public class MouseDownDispatcher : EcsDispatcher
    {
        public void OnMouseDown()
        {
            Publish(this);
        }
    }
}