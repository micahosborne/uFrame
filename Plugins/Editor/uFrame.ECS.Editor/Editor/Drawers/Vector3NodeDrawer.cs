namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class Vector3NodeDrawer : GenericNodeDrawer<Vector3Node,Vector3NodeViewModel> {
        
        public Vector3NodeDrawer(Vector3NodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
