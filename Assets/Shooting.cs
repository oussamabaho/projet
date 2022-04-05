using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootSpeed, shootTimer;
    public Transform shootPos;
    public GameObject bullet;
   
   
    // Start is called before the first frame update
   
   
   
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){

            Shoot();
        }
        
    }
    void Shoot(){
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.fixedDeltaTime, 0f);
        Debug.Log("Shoot");
        
    }
    
    /*private void OnTriggerEnter2D(Collider2D player){
        Debug.Log("Game Over");
    }
*/
 
}
