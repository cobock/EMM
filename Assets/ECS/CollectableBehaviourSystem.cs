using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class CollectableBehaviourSystem : SystemBase
{

    protected override void OnUpdate()
    {
        var time = UnityEngine.Time.deltaTime;
        Entities.ForEach((ref CollectedComponent coll, ref Rotation rot) =>
        {
            rot.Value = math.mul(math.normalize(rot.Value), quaternion.AxisAngle(math.up(), 10 * time));
        }).Schedule();
    }
}