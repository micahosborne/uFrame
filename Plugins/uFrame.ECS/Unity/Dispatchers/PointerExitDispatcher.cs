using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("Pointer Exit"), uFrameCategory("uGUI")]
    public class PointerExitDispatcher : EcsDispatcher, IPointerExitHandler
    {
        public PointerEventData PointerEventData { get; set; }
        public void OnPointerExit(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}