using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class PlayerBehaviourSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Vector2 input = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        Entities.ForEach((ref PlayerComponent player, ref Translation trans, ref Rotation rot) =>
        {
            player.RotationAngle += input.y;
            float3 targetDirection = new float3(math.sin(player.RotationAngle), 0, math.cos(player.RotationAngle));
            rot.Value = quaternion.LookRotationSafe(targetDirection, Vector3.up);

            trans.Value += targetDirection * player.Speed * input.x;
        }).Schedule();
    }
}
