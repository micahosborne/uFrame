using uFrame.Attributes;
using UnityEngine.EventSystems;

namespace uFrame.ECS
{
    [UFrameEventDispatcher("On Cancel"), uFrameCategory("uGUI")]
    public class CancelDispatcher : EcsDispatcher, ICancelHandler
    {
        public BaseEventData EventData { get; set; }

        public void OnCancel(BaseEventData eventData)
        {
            Publish(this);
        }
    }
}