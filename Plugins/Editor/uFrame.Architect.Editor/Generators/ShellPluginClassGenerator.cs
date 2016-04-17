using Invert.Core.GraphDesigner;
using Invert.uFrame.Editor;

public class ShellPluginClassGenerator : GenericNodeGenerator<ShellPluginNode>
{
    public override void Initialize(CodeFileGenerator codeFileGenerator)
    {
        base.Initialize(codeFileGenerator);
        TryAddNamespace("System.IO");

    }
}