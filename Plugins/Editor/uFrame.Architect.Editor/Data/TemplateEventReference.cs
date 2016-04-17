using System.Reflection;

public class TemplateEventReference : TemplateReference
{
    public EventInfo EventInfo
    {
        get { return MemberInfo as EventInfo; }
    }
}