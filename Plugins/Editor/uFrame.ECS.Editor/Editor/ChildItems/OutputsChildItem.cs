using uFrame.Attributes;

namespace Invert.uFrame.ECS
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Invert.Core.GraphDesigner;


    public class OutputsChildItem : OutputsChildItemBase, IActionFieldInfo, IActionIn
    {
        public bool IsGenericArgument { get { return false; } }
        public bool IsReturn { get { return false; } }
        public bool IsByRef { get { return false; } }
        public FieldDisplayTypeAttribute DisplayType { get { return new Out(MemberName); } }
        public bool IsBranch { get { return false; } }

        public bool IsOptional
        {
            get { return false; }
        }

        public IEnumerable<IMemberInfo> DelegateMembers { get { yield break; } }
        public bool IsDelegateMember { get; set; }

        public IActionFieldInfo ActionFieldInfo { get; set; }

        public string VariableName
        {
            get { return this.Name; }
        }

        public ITypeInfo VariableType
        {
            get { return MemberType; }
        }
        public IContextVariable Item { get { return null; } }

    }

    public partial interface IOutputsConnectable : Invert.Core.GraphDesigner.IDiagramNodeItem, Invert.Core.GraphDesigner.IConnectable
    {
    }
}
