using UnityEngine;

public class CustomEntityQuery : CustomTester
{
    public override void Calculate(int cnt, LayerMask layer, Transform origin, float radius)
    {
        float t = Time.time;



        PrintResult("EntityQuery", t);
    }
}
