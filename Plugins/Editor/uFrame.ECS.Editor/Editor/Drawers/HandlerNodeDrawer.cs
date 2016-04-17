namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class HandlerNodeDrawer : GenericNodeDrawer<HandlerNode,HandlerNodeViewModel> {
  
        public HandlerNodeDrawer(HandlerNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
