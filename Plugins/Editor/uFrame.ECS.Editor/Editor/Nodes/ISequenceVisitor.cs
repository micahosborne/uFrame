using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public interface ISequenceVisitor
    {
        void Visit(IDiagramNodeItem item);
        
    }
}