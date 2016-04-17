using Invert.Core.GraphDesigner.Unity.KoinoniaSystem.Data;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem
{
    public interface IDrawPackagePage
    {
        void DrawPackagePage(Rect bounds, UFramePackageDescriptor package);
    }
}