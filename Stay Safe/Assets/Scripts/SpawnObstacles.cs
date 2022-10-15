using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    
    public float timeBetweenSpawns;
    private float _spawnTime;
    
    
    // Update is called once per frame
    private void Update()
    {
        if (Time.time >= _spawnTime)
        {
            Spawn();
            _spawnTime = Time.time + timeBetweenSpawns;
        }
    }

    private void Spawn()
    {
        var randomX = Random.Range(minX, maxX);
        var randomY = Random.Range(minY, maxY);
        
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
