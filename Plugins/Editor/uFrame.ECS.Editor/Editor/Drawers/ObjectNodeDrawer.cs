namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ObjectNodeDrawer : GenericNodeDrawer<ObjectNode,ObjectNodeViewModel> {
        
        public ObjectNodeDrawer(ObjectNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
