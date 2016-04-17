namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class LiteralNodeDrawer : GenericNodeDrawer<LiteralNode,LiteralNodeViewModel> {
        
        public LiteralNodeDrawer(LiteralNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
