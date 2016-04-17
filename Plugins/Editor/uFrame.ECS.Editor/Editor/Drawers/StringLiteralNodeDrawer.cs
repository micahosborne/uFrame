namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class StringLiteralNodeDrawer : GenericNodeDrawer<StringLiteralNode,StringLiteralNodeViewModel> {
        
        public StringLiteralNodeDrawer(StringLiteralNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
