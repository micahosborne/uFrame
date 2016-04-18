using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Became Visible"), uFrameCategory("Unity Messages")]
    public class BecameVisibleDispatcher : EcsDispatcher
    {
        public void OnBecameVisible()
        {
            Publish(this);
        }
    }
}