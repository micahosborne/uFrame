using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public class ScrollGraphCommand : Command
    {
        public Vector2 Position;

        public string Title
        {
            get { return "ScrollTo"; }
            set { }
        }
    }
}