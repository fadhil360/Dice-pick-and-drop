using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceface : MonoBehaviour
{
    public DiceTotal dt;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Board")
        {
            dt.number = int.Parse(gameObject.name);
        }
        
    }
}
