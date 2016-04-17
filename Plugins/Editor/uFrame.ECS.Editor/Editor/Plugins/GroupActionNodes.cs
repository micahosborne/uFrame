using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public class GroupActionNodes : Command
    {
        public IDiagramNodeItem[] Items;
        public SequenceItemNode Node { get; set; }
    }
}