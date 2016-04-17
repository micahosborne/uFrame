using System;
using uFrame.Attributes;

namespace Invert.uFrame.ECS
{
    public class CustomActionInfo
    {
        public Type Type { get; set; }
        public ActionTitle TitleAttribute { get; set; }
        public uFrameCategory CategoryAttribute { get; set; }
    }
}