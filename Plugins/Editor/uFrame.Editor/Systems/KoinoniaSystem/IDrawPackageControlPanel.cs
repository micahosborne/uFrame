using Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Classes;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem
{
    public interface IDrawPackageControlPanel
    {
        void DrawControlPanel(Rect bounds, UFramePackage package);
    }
}