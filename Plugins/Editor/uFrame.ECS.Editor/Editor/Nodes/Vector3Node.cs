using System.CodeDom;
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
    
    public class Vector3Node : Vector3NodeBase {
        private float _x;
        private float _y;
        private float _z;

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

        [NodeProperty, JsonProperty]
        public float Z
        {
            get { return _z; }
            set { this.Changed("Z", ref _z, value); }
        }

        public override string ValueExpression
        {
            get { return string.Format("new Vector3({0}, {1}, {2})", X, Y, Z); }
        }

        public override ITypeInfo VariableType
        {
            get { return new SystemTypeInfo(typeof(Vector3)); }
        }
        public override CodeExpression GetCreateExpression()
        {
            return new CodeSnippetExpression(string.Format("new UnityEngine.Vector3({0}f,{1}f,{2}f)", X, Y, Z));
        }
    }
    
    public partial interface IVector3Connectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
