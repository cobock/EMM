using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class SpawnCollectableSystem : SystemBase
{
    BeginInitializationEntityCommandBufferSystem m_EntityCommandBufferSystem;

    protected override void OnCreate()
    {
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
    }

    protected override void OnUpdate()
    {
        var commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer().ToConcurrent();
        Unity.Mathematics.Random random = new Unity.Mathematics.Random((uint)UnityEngine.Random.Range(1, 100));
        Entities
            .WithBurst(FloatMode.Default, FloatPrecision.Standard, true)
            .ForEach(
            (Entity entity, int entityInQueryIndex, in SpawnCollectableComponent spawnCollectableComponent) => 
            {
            for (var x = 0; x < spawnCollectableComponent.numberOfCollectables; x++)
            {
                
                    Entity entityInstance = commandBuffer.Instantiate(entityInQueryIndex, spawnCollectableComponent.collectablePrefab);
                    float3 position = new float3(random.NextFloat(10), 1, random.NextFloat(10));
                    commandBuffer.SetComponent(entityInQueryIndex, entityInstance, new Translation{Value=position});
                    commandBuffer.AddComponent(entityInQueryIndex, entityInstance, new CollectedComponent { isCollected = false });
                }
                    commandBuffer.DestroyEntity(entityInQueryIndex,entity);
                }).ScheduleParallel();
        m_EntityCommandBufferSystem.AddJobHandleForProducer(Dependency);
        }
}