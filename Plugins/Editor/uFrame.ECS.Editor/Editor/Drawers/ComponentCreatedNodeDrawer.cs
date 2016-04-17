namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ComponentCreatedNodeDrawer : GenericNodeDrawer<ComponentCreatedNode,ComponentCreatedNodeViewModel> {
        
        public ComponentCreatedNodeDrawer(ComponentCreatedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
