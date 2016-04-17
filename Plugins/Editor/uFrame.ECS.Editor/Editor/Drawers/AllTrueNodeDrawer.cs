namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class AllTrueNodeDrawer : GenericNodeDrawer<AllTrueNode,AllTrueNodeViewModel> {
        
        public AllTrueNodeDrawer(AllTrueNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
