using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity = -2f;
    public int maxLife;
    public int currencieLife; 

    private void Start(){
        currencieLife = maxLife;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = new Vector2(velocity, 0f);
    }

    public void Damage(){
        currencieLife--;

        if(currencieLife <= 0){
            Destroy(gameObject);
        }
    }
}
