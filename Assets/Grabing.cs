using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabing : MonoBehaviour
{

    public bool grab = false;
    private Animator animator;
    public bool Thrown =false;
    public GameObject gb =null;
    private Dice dc;
    private void Start()
    {
        animator = GetComponent<Animator>();
        dc = GetComponent<Dice>();
    }

    private void Update()
    {
        if(gb!= null)
        {
            gb.transform.SetParent(transform,true);
            gb.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (!grab && gb!=null)
        {
            gb.transform.SetParent(null, true);
            gb.GetComponent<Rigidbody>().isKinematic = false;
            dc.LunchDie(gb);
            Debug.Log("jump");
            gb = null;
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "dice"&grab)
        {
            gb=other.gameObject;
        }
    }
    public void lunchDice()
    {
        animator.SetTrigger("Grab");
    }
}
