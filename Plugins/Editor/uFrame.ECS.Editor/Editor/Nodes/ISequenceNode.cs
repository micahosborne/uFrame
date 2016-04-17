using System.Collections.Generic;
using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS
{
    public interface ISequenceNode : IDiagramNode, ICodeOutput
    {
        bool CanGenerate { get; }
        string HandlerMethodName { get; }
      //  IEnumerable<IFilterInput> FilterInputs { get; }
      //  string EventType { get; set; }
        void Accept(ISequenceVisitor csharpVisitor);
        //SequenceItemNode Right { get; }

        SequenceItemNode StartNode { get; set; }
    }
}