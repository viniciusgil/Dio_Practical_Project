using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldSpript : MonoBehaviour
{
    private Vector3 originalPosition;

    public Vector2 frequency;

    public Vector2 distance;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var sin = Mathf.Sin(Time.time);
        var cos = Mathf.Cos(Time.time);
        transform.position = originalPosition + new Vector3(sin, cos, 0);
    }
}
