using System.Collections.Generic;
using Invert.Core.GraphDesigner;
using Invert.Json;

public interface IShellNodeConfigItem : IDocumentable, IClassTypeNode
{
    [JsonProperty, InspectorProperty]
    int Row { get; set; }
    [JsonProperty, InspectorProperty]
    int Column { get; set; }
    [InspectorProperty, JsonProperty]
    SectionVisibility Visibility { get; set; }
    string ReferenceClassName { get; }
    //string ClassName { get; }
    IEnumerable<IShellNodeConfigItem> IncludedInSections { get; }
    string TypeName { get; set; }
}