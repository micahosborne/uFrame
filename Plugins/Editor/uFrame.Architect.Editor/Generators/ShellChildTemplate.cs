using Invert.Core.GraphDesigner;

[TemplateClass(TemplateLocation.Both, ClassNameFormat = "{0}ChildItem")]
public class ShellChildTemplate : GenericNodeChildItem,
    IClassTemplate<ShellChildItemTypeNode>
{
    public string OutputPath
    {
        get { return Path2.Combine("Editor", "Sections"); }
    }

    public bool CanGenerate
    {
        get { return true; }
    }

    public void TemplateSetup()
    {
        Ctx.TryAddNamespace("Invert.Core.GraphDesigner");
        if (Ctx.IsDesignerFile)
        {
            if (Ctx.Data["Typed"] && Ctx.Data.BaseNode == null)
                Ctx.SetBaseType(typeof(GenericTypedChildItem));

            foreach (var item in Ctx.Data.IncludedInSections)
            {
                Ctx.AddInterface(item.ReferenceClassName);
            }
        }
        
    }

    public TemplateContext<ShellChildItemTypeNode> Ctx { get; set; }
}