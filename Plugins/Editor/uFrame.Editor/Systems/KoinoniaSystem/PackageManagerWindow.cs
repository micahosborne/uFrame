using Invert.IOC;
using UnityEditor;
using UnityEngine;

namespace Invert.Core.GraphDesigner.Unity.KoinoniaSystem
{
    public class PackageManagerWindow : EditorWindow
    {
        private UFrameContainer _container;

        void OnGUI()
        {
            Container = InvertApplication.Container;
            InvertApplication.SignalEvent<IDrawPackageManager>(_=>_.DrawPackageManager(new Rect(0,0,Screen.width,Screen.height)));
        }

        public UFrameContainer Container
        {
            get { return _container ?? (_container = InvertApplication.Container); }
            set { _container = value; }
        }

        void Update()
        {
            Repaint();
        }
    }
}