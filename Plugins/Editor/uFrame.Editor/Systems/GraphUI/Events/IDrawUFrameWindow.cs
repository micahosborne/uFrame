using UnityEngine;

namespace Invert.Core.GraphDesigner
{
    public interface IDrawUFrameWindow
    {
        void Draw(float width, float height, Vector2 scrollPosition, float scale);
    }
}