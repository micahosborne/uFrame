using System;
using System.CodeDom;
using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public interface IHandlerCodeWriter
    {
        Type For { get; }

        void WriteFilterMethod(HandlerNode handlerNode, TemplateContext ctx, CodeMemberMethod handlerFilterMethod, CodeMethodInvokeExpression invoker);

        void WriteSetupMethod(HandlerNode handlerNode, TemplateContext ctx, CodeMemberMethod handlerMethod);
    }
}