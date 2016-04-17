namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class StopTimerNodeDrawer : GenericNodeDrawer<StopTimerNode,StopTimerNodeViewModel> {
        
        public StopTimerNodeDrawer(StopTimerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
