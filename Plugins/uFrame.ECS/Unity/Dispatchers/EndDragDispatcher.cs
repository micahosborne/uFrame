using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On End Drag"), uFrameCategory("uGUI")]
    public class EndDragDispatcher : EcsDispatcher, IEndDragHandler
    {
        public PointerEventData PointerEventData { get; set; }

        public void OnEndDrag(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}