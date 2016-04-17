using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public interface IFilterInput : IDiagramNodeItem
    {
        string HandlerPropertyName { get;  }
        IMappingsConnectable FilterNode { get; }
        string MappingId { get; }
        // IEnumerable<IContextVariable> GetVariables();
    }
}