using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Mouse Up"), uFrameCategory("Unity Messages")]
    public class MouseUpDispatcher : EcsDispatcher
    {
        public void OnMouseUp()
        {
            Publish(this);
        }
    }
}