using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    float speed = 9.0f;
    float xBoundary = 13f;
    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    Vector3 GetRandomBallDirection()
    {
        int x = 1;
        int y = 1;
        if (Random.Range(0, 2) == 0) x *= -1; 
        if (Random.Range(0, 2) == 0) y *= -1;
        Vector3 dir = new Vector3(x, y, 0);
        return dir;
    }

    void Launch(Vector3 dir)
    {
        rb.AddForce(dir * speed, ForceMode.Impulse);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Launch(GetRandomBallDirection());
    }

    private void Reset()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Launch(GetRandomBallDirection());
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.x >  xBoundary )
        {
            Reset();
            playerOneScore++;
        }
        else if (transform.position.x < xBoundary * -1 )
        {
            Reset();
            playerTwoScore++;
        }
    }
}
