namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class VariableNodeDrawer : GenericNodeDrawer<VariableNode,VariableNodeViewModel> {
        
        public VariableNodeDrawer(VariableNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
