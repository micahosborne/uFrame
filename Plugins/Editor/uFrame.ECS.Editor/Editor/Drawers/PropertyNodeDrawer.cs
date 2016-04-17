namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class PropertyNodeDrawer : GenericNodeDrawer<PropertyNode,PropertyNodeViewModel> {
        
        public PropertyNodeDrawer(PropertyNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
