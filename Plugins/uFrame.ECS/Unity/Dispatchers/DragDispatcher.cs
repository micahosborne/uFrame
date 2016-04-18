using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Drag"), uFrameCategory("uGUI")]
    public class DragDispatcher : EcsDispatcher, IDragHandler
    {
        public PointerEventData PointerEventData { get; set; }

        public void OnDrag(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}