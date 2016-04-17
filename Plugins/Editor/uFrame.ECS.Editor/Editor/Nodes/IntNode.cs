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
    
    public class IntNode : IntNodeBase {
        private int _value;

        public override ITypeInfo VariableType
        {
            get { return new SystemTypeInfo(typeof(int)); }
        }

        public override string Name
        {
            get { return "Integer Variable"; }
            set
            {
                
            }
        }

        public override string ValueExpression
        {
            get { return Value.ToString(); }
        }

        [NodeProperty, JsonProperty]
        public int Value
        {
            get { return _value; }
            set { this.Changed("Value", ref _value, value); }
        }

        public override CodeExpression GetCreateExpression()
        {
            return new CodePrimitiveExpression(Value);
        }
    }
    
    public partial interface IIntConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
