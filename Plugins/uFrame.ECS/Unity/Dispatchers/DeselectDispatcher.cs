using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Deselect"), uFrameCategory("uGUI")]
    public class DeselectDispatcher : EcsDispatcher, IDeselectHandler
    {
        public BaseEventData EventData { get; set; }

        public void OnDeselect(BaseEventData eventData)
        {
            EventData = eventData;
            Publish(this);
        }

    }
}