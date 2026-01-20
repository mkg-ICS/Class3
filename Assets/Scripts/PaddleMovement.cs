using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] bool isLeft = false;
    [SerializeField] private float minY = -2.5f;
    [SerializeField] private float maxY = 4.5f;
    private float speed = 9.0f;
    private float vertInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var axis = isLeft ? "VerticalP1" : "VerticalP2";
        vertInput = Input.GetAxis(axis);
    }

    private void FixedUpdate()
    {
        Vector3 movement = Vector3.up * vertInput * Time.deltaTime * speed;
        Vector3 newPos = transform.position + movement;
        newPos.y = Mathf.Clamp(newPos.y, minY, maxY);
        rb.MovePosition(newPos);
    }
}
