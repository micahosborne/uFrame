namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ComponentDestroyedNodeDrawer : GenericNodeDrawer<ComponentDestroyedNode,ComponentDestroyedNodeViewModel> {
        
        public ComponentDestroyedNodeDrawer(ComponentDestroyedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
