namespace Invert.Core.GraphDesigner
{
    public interface IContextMenuQuery
    {
        void QueryContextMenu(ContextMenuUI ui, MouseEvent evt, params object[] obj);
    }
}