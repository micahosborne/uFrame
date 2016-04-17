using System.Collections.Generic;
using Invert.Core.GraphDesigner;

public interface IShellConnectable : IDiagramNode, IShellNode
{
    [ReferenceSection("Connectable To", SectionVisibility.Always, false)]
    IEnumerable<ShellConnectableReferenceType> ConnectableTo { get; }

    bool MultipleInputs { get; set; }

    bool MultipleOutputs { get; set; }
}