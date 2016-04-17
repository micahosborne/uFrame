namespace Invert.Core.GraphDesigner
{
    public interface IInspectorDrawer : IDrawer
    {
        void DrawInspector(IPlatformDrawer platformDrawer);
    }
}