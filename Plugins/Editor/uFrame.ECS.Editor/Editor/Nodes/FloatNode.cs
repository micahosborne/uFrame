using System.CodeDom;
using Invert.Json;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    using Data;
    
    public class FloatNode : FloatNodeBase {
        private float _value;
        public override string Name
        {
            get { return "Float Variable"; }
            set
            {

            }
        }
        public override ITypeInfo VariableType
        {
            get { return new SystemTypeInfo(typeof(float)); }
        }

        [NodeProperty, JsonProperty]
        public float Value
        {
            get { return _value; }
            set { this.Changed("Value", ref _value, value); }
        }

        public override CodeExpression GetCreateExpression()
        {
            return new CodePrimitiveExpression(Value);
        }

        public override string ValueExpression
        {
            get { return Value.ToString(); }
        }
    }
    
    public partial interface IFloatConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
