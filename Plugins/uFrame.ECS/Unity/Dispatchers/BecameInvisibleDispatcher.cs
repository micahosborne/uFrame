using uFrame.Attributes;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Became Invisible"), uFrameCategory("Unity Messages")]
    public class BecameInvisibleDispatcher : EcsDispatcher
    {
        public void OnBecameInvisible()
        {
            Publish(this);
        }
    }
}