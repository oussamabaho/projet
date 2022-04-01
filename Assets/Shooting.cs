using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootSpeed, shootTimer;
    public Transform shootPos;
    public GameObject bullet;
    private bool isShooting;
   
   
    // Start is called before the first frame update
   
   
   
    void Start()
    {
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !isShooting){

            StartCoroutine(Shoot());
        }
        
    }
    IEnumerator Shoot(){
        isShooting = true;
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.fixedDeltaTime, 0f);
        Debug.Log("Shoot");
        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
}
