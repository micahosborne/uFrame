using System.CodeDom;
using Invert.Json;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using Invert.Data;
    
    public class StringNode : StringNodeBase {
        private string _value;
        public override string Name
        {
            get { return "String Variable"; }
            set
            {

            }
        }
        [NodeProperty(InspectorType.TextArea), JsonProperty]
        public string Value
        {
            get { return _value; }
            set { this.Changed("Value", ref _value, value); }
        }

        public override string ValueExpression
        {
            get { return string.Format("\"{0}\"", JSONNode.Escape(Value)); }
        }

        public override ITypeInfo VariableType
        {
            get { return new SystemTypeInfo(typeof(string)); }
        }

        public override CodeExpression GetCreateExpression()
        {
            return new CodePrimitiveExpression(Value);
        }
    }
    
    public partial interface IStringConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
