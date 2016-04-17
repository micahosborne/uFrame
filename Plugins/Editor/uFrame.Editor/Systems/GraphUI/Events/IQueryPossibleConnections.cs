using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public interface IQueryPossibleConnections
    {
        void QueryPossibleConnections(SelectionMenu menu,DiagramViewModel diagramViewModel,
            ConnectorViewModel startConnector,
            Vector2 mousePosition);
    }
}