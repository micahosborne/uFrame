namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class BoolExpressionNodeDrawer : GenericNodeDrawer<BoolExpressionNode,BoolExpressionNodeViewModel> {
        
        public BoolExpressionNodeDrawer(BoolExpressionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
