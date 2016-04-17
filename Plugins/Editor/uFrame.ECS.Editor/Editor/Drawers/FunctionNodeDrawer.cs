namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class FunctionNodeDrawer : GenericNodeDrawer<FunctionNode,FunctionNodeViewModel> {
        
        public FunctionNodeDrawer(FunctionNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
