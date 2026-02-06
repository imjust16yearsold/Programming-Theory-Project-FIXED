using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(0, 1, 0);
    }
}
