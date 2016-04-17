using System.Collections.Generic;
using Invert.Core.GraphDesigner;

public interface IReferenceNode : IShellNode
{
    string ReferenceClassName { get; }
    [ReferenceSection("Acceptable Types", SectionVisibility.Always, false)]
    IEnumerable<ShellAcceptableReferenceType> AcceptableTypes { get; }
    IEnumerable<IShellNode> PossibleAcceptableTypes { get; }

}