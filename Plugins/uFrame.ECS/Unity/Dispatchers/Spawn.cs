using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace uFrame.ECS
{
    [ActionTitle("Spawn")]
    public class Spawn : UFAction
    {
        [In] public string PoolName;
        [In] public string PrefabName;
        [In] public Vector3 Position;
        [In] public Vector3 Rotation;
        [Out] public Entity Result;

        public override void Execute()
        {
            var evt = new SpawnEntity()
            {
                PoolName = PoolName,
                PrefabName = PrefabName,
                Position = Position,
                Rotation = Rotation,
                Result = Result,
            };
            System.Publish(evt);
            Result = evt.Result;

        }
    }
}