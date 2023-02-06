using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    
    public int maxLife;
    public int currencieLife;
    public Vector2 speed = new Vector2(50, 50);

    void Start()
    {
        currencieLife = maxLife;
    }
    
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var magnitude = 1000;
            var force = transform.position - other.transform.position;
            force.Normalize();
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(force * magnitude);
            Damage();
        }
    }

    public void Damage()
    {
        currencieLife--;

        if (currencieLife <= 0)
        {
            SceneManager.LoadScene("EndGameScene");
        }
    }
}
