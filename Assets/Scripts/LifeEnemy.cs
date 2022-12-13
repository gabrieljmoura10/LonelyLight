using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEnemy : MonoBehaviour
{
    public int maxLife;
    public int currencieLife;
        void Start()
    {
        currencieLife = maxLife;
    }

    public void Damage(){
        currencieLife = currencieLife - 1;

            if(currencieLife <= 0){
                Destroy(gameObject);
            }
    }
}
