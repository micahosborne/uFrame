namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class EventNodeDrawer : GenericNodeDrawer<EventNode,EventNodeViewModel> {
        
        public EventNodeDrawer(EventNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
