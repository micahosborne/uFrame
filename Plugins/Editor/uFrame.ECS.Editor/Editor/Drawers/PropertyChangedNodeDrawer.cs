namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class PropertyChangedNodeDrawer : GenericNodeDrawer<PropertyChangedNode,PropertyChangedNodeViewModel> {
        
        public PropertyChangedNodeDrawer(PropertyChangedNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
