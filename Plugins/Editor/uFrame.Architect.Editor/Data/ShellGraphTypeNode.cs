using System.Collections.Generic;
using System.Linq;
using Invert.Core.GraphDesigner;

public class ShellGraphTypeNode : ShellNode
{
    public override void Validate(List<ErrorInfo> errors)
    {
        base.Validate(errors);
        if (!RootNodeSlot.Outputs.Any())
        {
            errors.AddError("Root node must be specified.", this);
        }
    }

    [OutputSlot("Root Node")]
    public SingleOutputSlot<ShellNodeTypeNode> RootNodeSlot { get; set; }

    public ShellNodeTypeNode RootNode
    {
        get
        {
            return RootNodeSlot.Item;
        }
    }

    public override string ClassName
    {
        get { return string.Format("{0}Graph", Name); }
    }
}