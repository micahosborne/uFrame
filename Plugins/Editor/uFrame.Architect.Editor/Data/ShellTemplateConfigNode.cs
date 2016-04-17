using Invert.Core.GraphDesigner;
using Invert.Json;

public class ShellTemplateConfigNode : GenericNode
{
    
    private bool _autoInherit = true;

    public IShellNodeConfigItem NodeConfig
    {
        get { return this.InputFrom<IShellNodeConfigItem>(); }
    }

    [JsonProperty, NodeProperty]
    public string OutputPath { get; set; }
    [JsonProperty, NodeProperty]
    public string ClassNameFormat { get; set; }

    [JsonProperty,InspectorProperty(InspectorType.TypeSelection)]
    public string TemplateBaseClass { get; set; }

    [JsonProperty, NodeProperty]
    public TemplateLocation Files { get; set; }

    [JsonProperty,NodeProperty]
    public bool AutoInherit
    {
        get { return _autoInherit; }
        set { _autoInherit = value; }
    }
}