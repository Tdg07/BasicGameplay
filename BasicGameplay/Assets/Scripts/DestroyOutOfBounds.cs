using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopBound = 30.0f;
    private float LowerBound = -10.0f;

    // Start is called once before 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < LowerBound)
        {
            Destroy(gameObject); 
        }
    }
}
