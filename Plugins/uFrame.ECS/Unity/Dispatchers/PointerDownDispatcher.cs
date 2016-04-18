using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("Pointer Down"), uFrameCategory("uGUI")]
    public class PointerDownDispatcher : EcsDispatcher, IPointerDownHandler
    {
        public PointerEventData PointerEventData { get; set; }
        public void OnPointerDown(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}