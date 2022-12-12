using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootier : MonoBehaviour
{
    private Transform aimTransform;

    public Transform pontaArma;

    public GameObject disc;

    //public AudioSource audioSource;

    private void Awake() {
        aimTransform = transform.Find("Firepoint");
    }
    
    
    private void Update () {
        HandleAiming();
        handleShooting();
    }

    private void HandleAiming() {
        Vector3 mousePosition = GetMouseWorldPosition();
        Vector3 aimDirection = (mousePosition - aimTransform.position).normalized;

        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void handleShooting() {
        if (Input.GetMouseButtonDown(0)) {
            ShootingDisc();
        }
    }

    public static Vector3 GetMouseWorldPosition() {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
     } 

    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera) {
        return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    }
    
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera) {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

    public void ShootingDisc(){
        //audioSource.Play();
        GameObject discSpawnado = Instantiate(disc, pontaArma.position, pontaArma.rotation);
        discSpawnado.GetComponent<Rigidbody2D>().velocity = pontaArma.right * 10f;
        
    }
}
