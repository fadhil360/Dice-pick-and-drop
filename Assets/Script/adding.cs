using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adding : MonoBehaviour
{
    [SerializeField]
    GameObject dice;

    public void addDice()
    {
        Vector3 loc=new Vector3(Random.Range(-250,-211),25,Random.Range(-83,-55));
         Quaternion rotation = Quaternion.identity;
        Object.Instantiate(dice,loc,rotation);
    }
    public void removeDice()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("dice");
        if (temp != null) { 
            Destroy(temp);
        }
    }
}
