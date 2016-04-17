using System.Reflection;

public class TemplatePropertyReference : TemplateReference
{
    public PropertyInfo PropertyInfo
    {
        get { return MemberInfo as PropertyInfo; }
    }
}