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
    public float timeRemaining = 2;
    public float timeSpawnBetweenHordes = 5;

    void Start()
    {
        actualHorde = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (actualHorde < hordes.Count)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("actualHorde " + actualHorde);
                Debug.Log("hordes.Count " + hordes.Count);
                timeRemaining = hordes[actualHorde].GetComponent<Horde>().intervalTimeSpawn;
                HordeEnemy hordeEnemy = hordes[actualHorde].GetComponent<Horde>().getEnemy();

                if (hordeEnemy is null)
                {
                    actualHorde++;
                    timeRemaining = timeSpawnBetweenHordes;
                }
                else
                {
                    SpawnEnemy(hordeEnemy.enemy);
                }
                
            }
        }
        else
        {
            Debug.Log("Você não possui hordas no seu spawn");
        }
    }

    void SpawnEnemy(GameObject enemy)
    {
        positionY = Random.Range(positionMinY, positionMaxY);
        Instantiate(enemy, new Vector3(positionX, positionY, 0), Quaternion.identity);
    }
}
