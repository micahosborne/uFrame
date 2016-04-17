namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    
    
    public class LibraryNodeDrawer : GenericNodeDrawer<LibraryNode,LibraryNodeViewModel> {
        
        public LibraryNodeDrawer(LibraryNodeViewModel viewModel) : 
                base(viewModel) {
        }
    }
}
