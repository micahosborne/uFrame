namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class ColorNodeDrawer : GenericNodeDrawer<ColorNode,ColorNodeViewModel> {
        
        public ColorNodeDrawer(ColorNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
