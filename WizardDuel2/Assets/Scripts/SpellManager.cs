using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    // initalize in awake
    //on left controller trigger start listening
    //connect speech API to list
    //Speech API selects Spells from list
    //List of all possible Spells
    //Load Spell into shooter

    [SerializeField] private float maxMana = 100f;
    [SerializeField] private float currentMana;
    [SerializeField] private float manaRechargeRate = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
