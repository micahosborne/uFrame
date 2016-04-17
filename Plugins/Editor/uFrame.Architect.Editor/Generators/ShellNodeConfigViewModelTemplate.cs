using System;
using Invert.Core.GraphDesigner;

[TemplateClass(TemplateLocation.Both, ClassNameFormat = "{0}NodeViewModel", AutoInherit = false)]
public class ShellNodeConfigViewModelTemplate : GenericNodeViewModel<GenericNode>, IClassTemplate<ShellNodeConfig>
{
    public string OutputPath
    {
        get { return Path2.Combine("Editor", "ViewModels"); }
    }

    public bool CanGenerate
    {
        get { return true; }
    }

    public void TemplateSetup()
    {
        if (Ctx.IsDesignerFile)
        {
            if (Ctx.Data.BaseNode != null)
            {
                Ctx.SetBaseType(Ctx.Data.BaseNode.Name + "NodeViewModel");
            }
            else
            {
                // Ctx.SetType(Ctx.Data.ClassName + "ViewModel");
            }
            
            
        }

    }
    [GenerateProperty]
    public override NodeStyle NodeStyle
    {
        get
        {
            Ctx._("return Invert.Core.GraphDesigner.NodeStyle.{0}", Enum.GetName(typeof(NodeStyle), Ctx.Data.NodeStyle));
            return NodeStyle.Normal;
        }
    }

    public TemplateContext<ShellNodeConfig> Ctx { get; set; }

    // For templating
    public ShellNodeConfigViewModelTemplate()
        : base()
    {
    }

    public ShellNodeConfigViewModelTemplate(GenericNode graphItemObject, DiagramViewModel diagramViewModel)
        : base(graphItemObject, diagramViewModel)
    {
    }

    [GenerateConstructor(TemplateLocation.Both, "graphItemObject", "diagramViewModel"),Inside(TemplateLocation.Both)]
    public void ViewModelConstructor(GenericNode graphItemObject, DiagramViewModel diagramViewModel)
    {
        Ctx.CurrentConstructor.Parameters[0].Type = Ctx.Data.ClassName.ToCodeReference();

    }

}