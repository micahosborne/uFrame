namespace Invert.Core.GraphDesigner
{
    public interface INamespaceProvider
    {
        string GetNamespace(IDiagramNode node);
    }
}