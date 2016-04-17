using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public class ShowCommand : Command
    {
        public IDiagramNode Node { get; set; }
        public IGraphFilter Filter { get; set; }
        public Vector2 Position { get; set; }
    }
}