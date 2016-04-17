namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class AllFalseNodeDrawer : GenericNodeDrawer<AllFalseNode,AllFalseNodeViewModel> {
        
        public AllFalseNodeDrawer(AllFalseNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
