using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCharacter : MonoBehaviour
{
    public int maxLife;
    public int currencieLife;
//sexo
    void Start()
    {
        currencieLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(){
        currencieLife = currencieLife - 1;

            if(currencieLife <= 0){
                Application.LoadLevel("SampleScene");
            }
    }

}
