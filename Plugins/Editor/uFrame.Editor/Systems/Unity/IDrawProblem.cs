using UnityEngine;

namespace Invert.Core.GraphDesigner.Unity
{
    internal interface IDrawProblem
    {
        void DrawProblemInspector(Rect bounds, Problem problem);
    }
}