using System;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Systems.GraphUI
{
    public class DesignerWindowModalContent
    {
        public Action<Rect> Drawer { get; set; }
        public int ZIndex { get; set; }
    }
}