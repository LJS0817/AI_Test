using UnityEngine;

public class CustomOverlapSphere : CustomTester
{
    public override void Calculate(int cnt, LayerMask layer, Transform origin, float radius)
    {
        float t = Time.time;

        Collider[] hits = Physics.OverlapSphere(origin.position, radius, layer);

        if (hits.Length > 0)
        {
            Debug.Log(hits.Length);
        }

        PrintResult("OverlapSphere", t);
    }
}

