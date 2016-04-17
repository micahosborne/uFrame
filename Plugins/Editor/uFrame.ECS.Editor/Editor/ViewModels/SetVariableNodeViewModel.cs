using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class SetVariableNodeViewModel : SetVariableNodeViewModelBase {
        public override IEnumerable<string> Tags
        {
            get { yield break; }
        }

        public override INodeStyleSchema StyleSchema
        {
            get
            {
                return NormalStyleSchema;
            }
        }

        public override string Name
        {
            get { return "Set"; }
            set { base.Name = value; }
        }

        public SetVariableNodeViewModel(SetVariableNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
    }
}
