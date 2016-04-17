using UnityEngine;

namespace Invert.Core.GraphDesigner.Systems.GraphUI
{
    public interface IOverlayDrawer
    {
        void Draw(Rect bouds);
        Rect CalculateBounds(Rect diagramRect);
    }
}