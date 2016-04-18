using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Mouse Exit"), uFrameCategory("Unity Messages")]
    public class MouseExitDispatcher : EcsDispatcher
    {
        public void OnMouseExit()
        {
            Publish(this);
        }
    }
}