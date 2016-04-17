using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class CodeActionNodeViewModel : CodeActionNodeViewModelBase {
        
        public CodeActionNodeViewModel(CodeActionNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }

        protected override void CreateContent()
        {
            base.CreateContent();
            if (Action.Meta == null)
            {
                ContentItems.Add(new SectionHeaderViewModel()
                {
                    Name = "Please Save And Compile",
                    IsNewLine = true
                });
            }
        }
    }
}
