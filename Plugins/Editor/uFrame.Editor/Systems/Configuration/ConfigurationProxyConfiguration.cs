using System;
using System.Collections.Generic;

namespace Invert.Core.GraphDesigner
{
    public class ConfigurationProxyConfiguration : GraphItemConfiguration
    {
        public Func<GenericNode, IEnumerable<GraphItemConfiguration>> ConfigSelector { get; set; }
    }
}