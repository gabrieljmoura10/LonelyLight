using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LifeCharacter : MonoBehaviour
{
    public int maxLife;
    public int currencieLife;

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
                SceneManager.LoadScene("EndGameScene");
            }
    }

}
