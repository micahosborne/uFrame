using Invert.Core.GraphDesigner;
using Invert.IOC;
using Invert.Windows;

public class UnityWindows : DiagramPlugin
{
    public override bool Required
    {
        get { return true; }
    }
    public override void Initialize(UFrameContainer container)
    {
        base.Initialize(container);
        container.RegisterWindow<QuickAccessWindowViewModel>("QuickAccessWindowFactory")
          .HasPanel<QuickAccessWindowSearchPanel, QuickAccessWindowViewModel>()
          .WithDefaultInstance(_ => new QuickAccessWindowViewModel(new QuickAccessContext()
          {
              ContextType = typeof(IInsertQuickAccessContext)
          }));

        container.RegisterWindow<QuickAccessWindowViewModel>("ConnectionWindowFactory")
           .HasPanel<QuickAccessWindowSearchPanel, QuickAccessWindowViewModel>()
           .WithDefaultInstance(_ => new QuickAccessWindowViewModel(new QuickAccessContext()
           {
               ContextType = typeof(IConnectionQuickAccessContext)
           }));
    }
}