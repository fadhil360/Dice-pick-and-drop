using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTotal : MonoBehaviour
{
    GameObject totalui;
    public int number;
    private Rigidbody rb;
    public bool send = false;
    void Start()
    {
        totalui = GameObject.FindGameObjectWithTag("Dicetotal");
        rb=gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (rb.velocity != Vector3.zero)
        {
            send = false;
        }
        if (rb.velocity == Vector3.zero && !send)
        {
            totalui.GetComponent<stat>().number = totalui.GetComponent<stat>().number + number;
            send = true;

        }
        
    }
}
