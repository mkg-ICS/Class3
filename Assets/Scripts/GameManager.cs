using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] Ball ball;
    [SerializeField] UIManager ui;
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.Launch(GetRandomBallDirection());
    }


    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x > xBoundary)
        {
            ball.Reset();
            ball.Launch(GetRandomBallDirection());
            playerOneScore++;
        }
        else if (ball.transform.position.x < xBoundary * -1)
        {
            ball.Reset();
            ball.Launch(GetRandomBallDirection());
            playerTwoScore++;
        }
        ui.UpdateScore(playerOneScore, playerTwoScore);
    }
}
