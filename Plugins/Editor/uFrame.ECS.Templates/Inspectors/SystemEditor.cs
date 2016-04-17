using Invert.Core;
using UnityEditor;

[UnityEditor.CustomEditor(typeof(uFrame.ECS.EcsSystem),true)]
public class SystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        InvertApplication.SignalEvent<IDrawUnityInspector>(_ => _.DrawInspector(target));
    }
}