using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject Target;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + offset;
    }
}
