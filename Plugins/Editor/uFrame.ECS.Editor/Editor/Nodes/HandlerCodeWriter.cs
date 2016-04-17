using System;
using System.CodeDom;
using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public abstract class HandlerCodeWriter<TFor> : IHandlerCodeWriterFor<TFor>
    {
        public Type For
        {
            get { return typeof(TFor); }
        }

        public abstract void WriteFilterMethod(HandlerNode handlerNode, TemplateContext ctx, CodeMemberMethod handlerFilterMethod,
            CodeMethodInvokeExpression invoker);

        public abstract void WriteSetupMethod(HandlerNode handlerNode, TemplateContext ctx, CodeMemberMethod handlerMethod);

    }
}