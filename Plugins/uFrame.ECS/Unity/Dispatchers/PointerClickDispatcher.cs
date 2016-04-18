using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("Pointer Click"), uFrameCategory("uGUI")]
    public class PointerClickDispatcher : EcsDispatcher, IPointerClickHandler
    {
        public PointerEventData PointerEventData { get; set; }
        public void OnPointerClick(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}