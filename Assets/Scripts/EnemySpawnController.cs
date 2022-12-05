using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    public float positionX;
    public float positionMaxY;
    public float positionMinY;
    private float positionY;
    private int actualHorde;
    public List<GameObject> hordes;
    public float totalTime = 2;
    public float timeRemaining = 2;

    void Start()
    {
        actualHorde = 0;
        //SpawnEnemy(enemy);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            timeRemaining = totalTime;
            SpawnEnemy(hordes[actualHorde].GetComponent<Horde>().getEnemy().enemy);
        }
       
    }

    void SpawnEnemy(GameObject enemy)
    {
        positionY = Random.Range(positionMinY, positionMaxY);
        Instantiate(enemy, new Vector3(positionX, positionY, 0), Quaternion.identity);
    }
}
