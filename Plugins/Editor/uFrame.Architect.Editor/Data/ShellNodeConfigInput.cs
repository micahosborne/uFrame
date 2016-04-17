using System.Text.RegularExpressions;
using Invert.Core.GraphDesigner;
using Invert.Data;
using Invert.Json;

public class ShellNodeConfigInput : ShellNodeConfigItem, IShellSlotType
{
    private bool _allowMultiple;
    private bool _allowSelection;

    public bool IsOutput
    {
        get { return false; }
        set
        {

        }
    }
    
    [JsonProperty, InspectorProperty]
    public bool AllowMultiple
    {
        get { return _allowMultiple; }
        set
        {
            this.Changed("AllowMultiple",ref _allowMultiple, value);
        }
    }

    public override string TypeName
    {
        get
        {
            return Regex.Replace(Name, @"[^a-zA-Z0-9_\.]+", "");

        }
        set { }
    }

    public override string ClassName
    {
        get { return TypeName; }
    }

    [InspectorProperty, JsonProperty]
    public bool AllowSelection
    {
        get { return _allowSelection; }
        set { this.Changed("AllowSelection",ref _allowSelection, value); }
    }
}