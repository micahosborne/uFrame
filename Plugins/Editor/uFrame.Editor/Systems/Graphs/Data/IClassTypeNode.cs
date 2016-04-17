using System;

namespace Invert.Core.GraphDesigner
{
    [Obsolete]
    public interface IClassTypeNode : IDiagramNodeItem
    {
        string ClassName { get; }
    }
}