using uFrame.Attributes;

namespace Invert.uFrame.ECS
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;
    using Invert.Data;

    public class InputsChildItem : InputsChildItemBase, IActionFieldInfo
    {
        public bool IsGenericArgument { get { return false; } }
        public bool IsReturn { get { return false; } }
        public bool IsByRef { get { return false; } }
        public FieldDisplayTypeAttribute DisplayType { get { return new In(MemberName); } }
        public bool IsBranch { get { return false; } }

        private bool _isOptional;
        [InspectorProperty]
        public bool IsTypeSelection
        {
            get { return this["IsTypeSelection"]; }
            set { this["IsTypeSelection"] = value; }
        }

        public override string RelatedTypeName
        {
            get
            {
                if (IsTypeSelection)
                    return "System.Type";
                return base.RelatedTypeName;
            }
        }

        public bool IsOptional
        {
            get { return _isOptional; }
            set { this.Changed("IsOptional", ref _isOptional, value); }
        }

        public IEnumerable<IMemberInfo> DelegateMembers
        {
            get { yield break; }
        }

        public bool IsDelegateMember { get; set; }

        public override IEnumerable<Attribute> GetAttributes()
        {
            if (IsTypeSelection)
            {
                yield return new ActionTypeSelection()
                { 
                    AssignableTo = Type
                };
            }
        }
    }

    public partial interface IInputsConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
