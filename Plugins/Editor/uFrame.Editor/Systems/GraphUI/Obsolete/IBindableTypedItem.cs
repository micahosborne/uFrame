namespace Invert.Core.GraphDesigner
{
    public interface IBindableTypedItem :  ITypedItem
    {
        bool AllowEmptyRelatedType { get;  }
        string FieldName { get; }
        string NameAsChangedMethod { get;  }
        string ViewFieldName { get; }

       
       
    }
}