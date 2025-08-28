using UnityEngine;

public class CustomTester
{
    public virtual void Calculate(int cnt, LayerMask layer, Transform origin, float radius) { }
    protected void PrintResult(string name, float t)
    {
        Debug.Log(name + " : " + (Time.time - t) + "ms");
    }
}
