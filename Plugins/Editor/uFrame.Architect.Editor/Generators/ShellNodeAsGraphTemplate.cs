using Invert.Core.GraphDesigner;

[TemplateClass(TemplateLocation.Both, ClassNameFormat = "{0}Graph")]
public class ShellNodeAsGraphTemplate : GenericGraphData<GenericNode>, IClassTemplate<ShellNodeConfig>
{
    public string OutputPath
    {
        get { return Path2.Combine("Editor", "Graphs"); }
    }

    public bool CanGenerate
    {
        get { return Ctx.Data.IsGraphType; }
    }

    public void TemplateSetup()
    {
        Ctx.TryAddNamespace("Invert.Core.GraphDesigner");
        if (Ctx.IsDesignerFile)
        {
            Ctx.SetBaseType("GenericGraphData<{0}>", Ctx.Data.ClassName);
        }
    }

    public TemplateContext<ShellNodeConfig> Ctx { get; set; }
}