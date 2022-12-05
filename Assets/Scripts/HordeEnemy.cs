using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float minSpawnProbability;
    public float maxSpawnProbability;

    public bool IsSpawnEnemy(int probability)
    {
        return probability >= minSpawnProbability && probability <= maxSpawnProbability;
    }
}
