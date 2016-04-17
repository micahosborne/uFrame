using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public class LibraryWorkspace : Workspace
    {
        public override CompilationMode CompilationMode
        {
            get { return CompilationMode.Always; }
        }
    }

    public class EcsWorkspace : Workspace
    {
        public override CompilationMode CompilationMode
        {
            get { return CompilationMode.Always; }
        }
    }
}