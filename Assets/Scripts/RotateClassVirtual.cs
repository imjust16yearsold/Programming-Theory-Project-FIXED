using UnityEngine;

public class RotateClassVirtual : MonoBehaviour
{
    void Update()
    {
        Rotate();
    }
    public virtual void Rotate()
    {
        transform.Rotate(0, 0, 1);
    }
}
