using Invert.Core.GraphDesigner;

public class ShellNodeTypeNodeViewModel : GenericNodeViewModel<ShellNodeTypeNode>
{
    public ShellNodeTypeNodeViewModel(ShellNodeTypeNode graphItemObject, DiagramViewModel diagramViewModel) : base(graphItemObject, diagramViewModel)
    {
    }

    public override NodeColor Color
    {
        get { return GraphItem.Color; }
    }
}