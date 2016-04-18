using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("Pointer Enter"), uFrameCategory("uGUI")]
    public class PointerEnterDispatcher : EcsDispatcher, IPointerEnterHandler
    {
        public PointerEventData PointerEventData { get; set; }
        public void OnPointerEnter(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}