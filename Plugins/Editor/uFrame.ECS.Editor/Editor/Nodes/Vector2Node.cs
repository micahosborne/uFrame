using Invert.Json;
using UnityEngine;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core;
    using Invert.Core.GraphDesigner;
using Invert.Data;    
    
    public class Vector2Node : Vector2NodeBase {
        private float _x;
        private float _y;
        public override string Name
        {
            get { return "Vector2 Variable"; }
            set
            {

            }
        }

        [NodeProperty, JsonProperty]
        public float X
        {
            get { return _x; }
            set { this.Changed("X", ref _x, value); }
        }

        [NodeProperty, JsonProperty]
        public float Y
        {
            get { return _y; }
            set { this.Changed("Y", ref _y, value); }
        }

        public override ITypeInfo VariableType
        {
            get { return new SystemTypeInfo(typeof(Vector2)); }
        }
        public override string ValueExpression
        {
            get { return string.Format("new Vector2( {0}, {1} )", X, Y); }
        }

    }
    
    public partial interface IVector2Connectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
