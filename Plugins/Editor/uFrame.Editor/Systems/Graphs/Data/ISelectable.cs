namespace Invert.Core.GraphDesigner
{
    public interface ISelectable : IGraphItem
    {
        bool IsSelected { get; set; }
    }
}