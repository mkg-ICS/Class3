using System.IO;
using UnityEngine;

public class Rotor : MonoBehaviour
{
    private float rotSpeed = 2000.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = Vector3.up * Time.deltaTime * rotSpeed;
        transform.Rotate(rot);
    }
}
