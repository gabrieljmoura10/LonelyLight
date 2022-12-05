using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public float positionX;
    public float positionMaxY;
    public float positionMinY;
    private float positionY;

    public GameObject enemy;

    void Start()
    {

        SpawnEnemy(enemy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy(GameObject enemy)
    {
        positionY = Random.Range(positionMinY, positionMaxY);
        Instantiate(enemy, new Vector3(positionX, positionY, 0), Quaternion.identity);
    }
}
