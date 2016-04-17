using Invert.Core.GraphDesigner;
using UnityEngine;

namespace Invert.uFrame.ECS
{
    public class AddSlotInputNodeCommand : Command
    {
        public IContextVariable Variable { get; set; }
        public HandlerNode Handler { get; set; }
        public Vector2 Position { get; set; }
        public ActionIn Input { get; set; }
        public DiagramViewModel DiagramViewModel { get; set; }
    }
}