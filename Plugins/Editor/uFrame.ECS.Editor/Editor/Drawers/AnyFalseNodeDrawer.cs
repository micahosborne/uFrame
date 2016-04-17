namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class AnyFalseNodeDrawer : GenericNodeDrawer<AnyFalseNode,AnyFalseNodeViewModel> {
        
        public AnyFalseNodeDrawer(AnyFalseNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
