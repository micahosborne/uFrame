namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class StartTimerNodeDrawer : GenericNodeDrawer<StartTimerNode,StartTimerNodeViewModel> {
        
        public StartTimerNodeDrawer(StartTimerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
