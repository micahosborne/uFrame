using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public interface ISetupCodeWriter
    {
        void WriteSetupCode(ISequenceVisitor visitor, TemplateContext ctx);
    }
}