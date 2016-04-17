namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ConditionNodeDrawer : GenericNodeDrawer<ConditionNode,ConditionNodeViewModel> {
        
        public ConditionNodeDrawer(ConditionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
