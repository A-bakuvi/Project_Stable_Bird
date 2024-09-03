using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    float _speed = 5f;
    float _leftEdge;



    void Start()
    {
        _leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5f;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (transform.position.x < _leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
