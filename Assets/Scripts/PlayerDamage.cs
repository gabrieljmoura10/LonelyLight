using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    
    private void Enter2D(Collider2D other){
        if(other.gameObject.CompareTag("EnemyTest")){
            other.gameObject.GetComponent<LifeCharacter>().Damage();
        }
        

    }
}
