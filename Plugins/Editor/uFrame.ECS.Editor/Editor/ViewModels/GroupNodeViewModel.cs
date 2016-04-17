using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;


    public class GroupNodeViewModel : GroupNodeViewModelBase
    {

        public GroupNodeViewModel(GroupNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }


        public virtual bool ShowContextVariables
        {
            get { return IsVisible(SectionVisibility.WhenNodeIsFilter); }
        }
        protected override void CreateContent()
        {
         
            base.CreateContent();

        }
    }
}
