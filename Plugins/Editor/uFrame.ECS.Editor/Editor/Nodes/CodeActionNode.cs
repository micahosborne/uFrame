namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core;
    using Invert.Core.GraphDesigner;
    
    
    public class CodeActionNode : CodeActionNodeBase {
        [InspectorProperty]
        public override string MetaType
        {
            get { return FullName; }
            set { base.MetaType = value; }
        }

        public override void Validate(List<ErrorInfo> errors)
        {
            //base.Validate(errors);
        }
    }
    
    public partial interface ICodeActionConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable {
    }
}
