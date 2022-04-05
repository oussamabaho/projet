using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colbullet : MonoBehaviour
{

void OnCollisionEnter2D(Collision2D collision){
        
        GameObject collisionGameObject = collision.gameObject;
        if(collisionGameObject.tag.Equals("Ennemi")){
            Destroy(collisionGameObject);
        }
       Destroy(collisionGameObject);
    }
}
