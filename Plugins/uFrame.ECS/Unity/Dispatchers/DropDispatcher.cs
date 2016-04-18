using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Drop"), uFrameCategory("uGUI")]
    public class DropDispatcher : EcsDispatcher, IDropHandler
    {
        public PointerEventData PointerEventData { get; set; }

        public void OnDrop(PointerEventData eventData)
        {
            PointerEventData = eventData;
            Publish(this);
        }
    }
}