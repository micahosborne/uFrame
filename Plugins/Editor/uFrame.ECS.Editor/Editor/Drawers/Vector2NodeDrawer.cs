namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class Vector2NodeDrawer : GenericNodeDrawer<Vector2Node,Vector2NodeViewModel> {
        
        public Vector2NodeDrawer(Vector2NodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
