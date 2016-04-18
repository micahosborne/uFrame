using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("Pointer Up"), uFrameCategory("uGUI")]
    public class PointerUpDispatcher : EcsDispatcher, IPointerUpHandler
    {
        public PointerEventData PointerEventData { get; set; }
        public void OnPointerUp(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}