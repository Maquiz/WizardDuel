using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Required components
public class Spell : MonoBehaviour
{
    public SpellScriptableObject spellToCast;

    private void Update(){
        // spell movement 
    }

    private void OnTriggerEnter(Collider other) {
        //apply effect to what we hit
        // apply hit particle effects
        //apply sound effects
        Destroy(this.gameObject);
    }
}
