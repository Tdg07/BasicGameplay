using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }
}
