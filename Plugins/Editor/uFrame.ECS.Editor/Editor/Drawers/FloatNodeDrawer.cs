namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class FloatNodeDrawer : GenericNodeDrawer<FloatNode,FloatNodeViewModel> {
        
        public FloatNodeDrawer(FloatNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
