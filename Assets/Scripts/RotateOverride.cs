using UnityEngine;

public class RotateOverride : RotateClassVirtual
{
    void Update()
    {
        Rotate();
    }
    public override void Rotate()
    {
        transform.Rotate(0, 0, 2);
    }
}
