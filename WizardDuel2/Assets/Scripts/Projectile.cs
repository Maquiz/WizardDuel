using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private bool colided;

    public GameObject impactVFX;

    //Damage and type of damage or effects
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Bullet" && other.gameObject.tag != "Player" && !colided) {
            colided = true;

            var impact = Instantiate(impactVFX, other.contacts[0].point,Quaternion.identity) as GameObject;

            Destroy(impact, 2);
            Destroy(gameObject);
        }
        
    }
}
