using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Scroll"), uFrameCategory("uGUI")]
    public class ScrollDispatcher : EcsDispatcher, IScrollHandler
    {
        public PointerEventData PointerEventData { get; set; }

        public void OnScroll(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }

    }
}