using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Mathematics.Geometry;
using Unity.Physics;
using UnityEngine;

public class CustomOverlapAABB : CustomTester
{
    public override void Calculate(int cnt, LayerMask layer, Transform origin, float radius)
    {
        Vector3 position = origin.position;
        float t = Time.time;

        CollisionFilter filter = new CollisionFilter
        {
            BelongsTo = (uint)layer.value,
            CollidesWith = (uint)layer.value
        };

        var input = new OverlapAabbInput
        {
            Aabb = new Aabb
            {
                Max = new float3(position.x + radius, position.y + radius, position.z + radius),
                Min = new float3(position.x - radius, position.y - radius, position.z - radius)
            },
            Filter = collisionFilter,
        };
        var indexList = new NativeList<int>(Allocator.Temp);
        collisionWorld.OverlapAabb(input, ref indexList);


        PrintResult("OverlapAABB", t);
    }
}