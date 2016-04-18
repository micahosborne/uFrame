using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Begin Drag"), uFrameCategory("uGUI")]
    public class BeginDragDispatcher : EcsDispatcher, IBeginDragHandler
    {
        public PointerEventData PointerEventData { get; set; }

        public void OnBeginDrag(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}