using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
float _speed = 10f;
float _horizontal;
float _vertical;

// Update is called once per frame
void Update()
{
    _horizontal = Input.GetAxis("Horizontal");
    _vertical = Input.GetAxis("Vertical");
}
void FixedUpdate()
{
    MovePlayer();
}

void MovePlayer()
{
    if (_horizontal != 0 || _vertical != 0)
    {
        transform.Translate(_horizontal * _speed * Time.deltaTime, _vertical * _speed * Time.deltaTime, 0f);
    }
}
*/ // how to move player with transform.Translate()
/*

Rigidbody2D _rb;
float _speed = 10f;
float _horizontal;
float _vertical;

// Start is called before the first frame update
void Start()
{
    _rb = GetComponent<Rigidbody2D>();
}

// Update is called once per frame
void Update()
{
    _horizontal = Input.GetAxis("Horizontal");
}
void FixedUpdate()
{
    MovePlayer();
}

void MovePlayer()
{
    if(_horizontal != 0)
    {
        _rb.AddForce(new Vector2(_horizontal * _speed ,0f));
    }
}
*/ // how to move player with Rigidbody2D

public class TeleportPlayer : MonoBehaviour
{
    
    float _speed = 3f;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _button;
    [SerializeField] GameObject _spawner;
    [SerializeField] GameObject _camera;
    //[SerializeField] GameObject _pipes;

    void Start()
    {
        _button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(new Vector2(0f, _speed) * Time.deltaTime, Space.World);

        }
        else
        {
            gameObject.transform.Translate(new Vector2(0f, -_speed) * Time.deltaTime, Space.World);
        }
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collisio.n.gameObject.tag == "Obstacle" )
        {
            _spawner.SetActive(false);
            _player.SetActive(false);
            Debug.Log("You Lost!!!");
            _button.SetActive(true);
        }
    }*/
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
            _spawner.SetActive(false);
            _player.SetActive(false);
            Debug.Log("You Lost!!!");
            _button.SetActive(true);
        }
    }

}



































