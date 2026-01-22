using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    float speed = 9.0f;

    public void Launch(Vector3 dir)
    {
        rb.AddForce(dir * speed, ForceMode.Impulse);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public void Reset()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
