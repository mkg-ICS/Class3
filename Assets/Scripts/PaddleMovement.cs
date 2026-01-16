using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    float vert;
    private float speed = 9.0f;
    private bool isLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vert = Input.GetAxis("Vertical");
        if (isLeft)
        {
            vert = Input.GetAxis("VerticalP1");
        }
        else
        {
            vert = Input.GetAxis("VerticalP2");
        }
    }

            private void FixedUpdate()
            {
                Vector3 movement = Vector3.up * vert * Time.deltaTime * speed;
                rb.MovePosition(transform.position + movement);
            }
}
