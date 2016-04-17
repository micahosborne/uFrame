namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class IntNodeDrawer : GenericNodeDrawer<IntNode,IntNodeViewModel> {
        
        public IntNodeDrawer(IntNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
