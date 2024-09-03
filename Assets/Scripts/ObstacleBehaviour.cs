using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    /*
    [SerializeField] GameObject[] _obstaclePrefabs;
    public float _obstacleSpawnTime = 2f;
    float _timeUntilObstacleSpawn;
    public float _obstacleSpeed = 1f;

    void FixedUpdate()
    {
        SpawnLoop();
    }

    void SpawnLoop()
    {
        _timeUntilObstacleSpawn += Time.deltaTime;
        if (_timeUntilObstacleSpawn >= _obstacleSpawnTime)
        {
            Spawn();
            _timeUntilObstacleSpawn = 0f;
        }
    }

    void Spawn()
    {
        GameObject _obstacleToSpawn = _obstaclePrefabs[Random.Range(0, _obstaclePrefabs.Length)];

        GameObject _spawnedObstacle = Instantiate(_obstacleToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D _obstacleRB = _spawnedObstacle.GetComponent<Rigidbody2D>();

        _obstacleRB.velocity = Vector2.left * _obstacleSpeed;
    }
*/ // --> how to spawn obstacles


    [SerializeField] GameObject _prefabs;
    [SerializeField] float _spawnRate = 1f;
    [SerializeField] float _minHeight = -2f;
    [SerializeField] float _maxHeight = 2f;
    //[SerializeField] float _speed = 5f;


    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), _spawnRate, _spawnRate);
    }

    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    void Spawn()
    {
        GameObject pipes = Instantiate(_prefabs, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(_minHeight, _maxHeight);
        //transform.position = Vector3.left * _speed * Time.deltaTime;

    }

}



