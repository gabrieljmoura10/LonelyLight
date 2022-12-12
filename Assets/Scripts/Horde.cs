using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horde : MonoBehaviour
{
    public int enemyCount;
    public float intervalTimeSpawn;
    public GameObject boss;
    public List<HordeEnemy> enemies = new List<HordeEnemy>();
    
    public HordeEnemy getEnemy()
    {
        if (enemyCount == 0)
        {
            return null;
        }
        this.enemyCount--;
        int probabilitySpawn = Random.Range(0,100);

        for(int i =0; i < enemies.Count; i++)
        {
            HordeEnemy hordeEnemy = enemies[i].GetComponent<HordeEnemy>();
            if(enemies.Count == 1)
            {
                return hordeEnemy;
            }

            if (hordeEnemy.IsSpawnEnemy(probabilitySpawn))
            {
                return hordeEnemy;
            }
        }
        return null;
       
    }
}
