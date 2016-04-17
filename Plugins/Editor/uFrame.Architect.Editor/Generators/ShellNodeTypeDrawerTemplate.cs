using Invert.Core.GraphDesigner;

[TemplateClass(TemplateLocation.Both, ClassNameFormat = "{0}NodeDrawer")]
public class ShellNodeTypeDrawerTemplate : GenericNodeDrawer<GenericNode, GenericNodeViewModel<GenericNode>>, IClassTemplate<ShellNodeTypeNode>
{
    public string OutputPath
    {
        get { return Path2.Combine("Editor", "Drawers"); }
    }

    public bool CanGenerate
    {
        get { return true; }
    }

    public void TemplateSetup()
    {
        Ctx.TryAddNamespace("Invert.Core.GraphDesigner");
        //Ctx.SetBaseTypeArgument(Ctx.Data.ClassName);
        Ctx.SetBaseType("GenericNodeDrawer<{0},{1}>", Ctx.Data.ClassName, Ctx.Data.Name + "NodeViewModel");
    }

    public TemplateContext<ShellNodeTypeNode> Ctx { get; set; }

    // For templating
    public ShellNodeTypeDrawerTemplate()
        : base()
    {
    }

    public ShellNodeTypeDrawerTemplate(GenericNodeViewModel<GenericNode> viewModel)
        : base(viewModel)
    {
    }

    [GenerateConstructor(TemplateLocation.Both, "viewModel")]
    public void DrawerConstructor(GenericNodeViewModel<GenericNode> viewModel)
    {
        Ctx.CurrentConstructor.Parameters[0].Type = (Ctx.Data.Name + "NodeViewModel").ToCodeReference();

    }

}