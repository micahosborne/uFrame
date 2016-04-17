using Invert.Core.GraphDesigner;

namespace Invert.uFrame.ECS {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class VariableNodeViewModel : VariableNodeViewModelBase {
        
        public VariableNodeViewModel(VariableNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) : 
                base(graphItemObject, diagramViewModel) {
        }
        public VariableNode Variable
        {
            get
            {
                return GraphItem as VariableNode;
            }
        }
        public override string Name
        {
            get
            {
                return !string.IsNullOrEmpty(Variable.VariableName) ?
                    Variable.VariableName : base.Name;
            }
        }
        protected override void CreateContent()
        {
            
            foreach (var item in GraphItem.GraphItems.OfType<GenericSlot>())
            {
                var vm = new InputOutputViewModel()
                {
                    Name = item.Name,
                    IsOutput = item is IActionOut,
                    IsInput = !(item is IActionOut),
                    DataObject = item,
                    IsNewLine = true,
                    DiagramViewModel = DiagramViewModel
                };
                ContentItems.Add(vm);
                if (vm.InputConnector != null)
                {
                    vm.InputConnector.Style = ConnectorStyle.Circle;
                    vm.InputConnector.TintColor = UnityEngine.Color.green;
                }

            }
           
            base.CreateContent();
        }
    }
}
