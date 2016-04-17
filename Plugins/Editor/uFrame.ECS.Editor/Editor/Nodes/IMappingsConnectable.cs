using System.Collections;
using System.Collections.Generic;

namespace Invert.uFrame.ECS
{
    public partial interface IMappingsConnectable : Invert.Core.GraphDesigner.IDiagramNode, Invert.Core.GraphDesigner.IConnectable
    {
        System.Collections.Generic.IEnumerable<ComponentNode> SelectComponents { get; }

        string GetContextItemName(string mappingId);

        string ContextTypeName { get; }

        string SystemPropertyName { get; }

        string EnumeratorExpression { get; }

        IEnumerable<IContextVariable> GetVariables(IFilterInput filterInput);

        string MatchAndSelect(string mappingExpression);

        string DispatcherTypesExpression();
        IEnumerable<PropertiesChildItem> GetObservableProperties();
    }
    
}