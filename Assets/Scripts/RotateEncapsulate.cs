using UnityEngine;

public class RotateEncapsulate : MonoBehaviour
{
    private float speed;
    public float protectSpeed
    {
        get
        {
            return speed;
        }
        set
        { 
            if (value > 0.2f)
            {
                Debug.Log("The value shouldn't be greater than 0.2!");
                speed = 0.2f;
            }
            else
            {
                speed = value;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        protectSpeed = 2.0f;
        transform.Rotate(0, protectSpeed, 0);
    }
}
