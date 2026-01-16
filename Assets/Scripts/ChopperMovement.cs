using JetBrains.Rider.Unity.Editor;
using UnityEngine;

public class ChopperMovement : MonoBehaviour
{
    float speed = 9.0f;
    private Rigidbody rb;
    float horiz;
    float vert;
    int newtons = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, vert, horiz) * Time.deltaTime * speed;
        rb.AddForce(movement * newtons);
    }
}
