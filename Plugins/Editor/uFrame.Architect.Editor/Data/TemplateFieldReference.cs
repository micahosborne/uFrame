using System.Reflection;

public class TemplateFieldReference : TemplateReference
{
    public FieldInfo FieldInfo
    {
        get { return MemberInfo as FieldInfo; }
    }

}