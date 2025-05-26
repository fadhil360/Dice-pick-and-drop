using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public float launchForce; // Force to launch the dice
    public float torqueAmount; // Torque to make the dice spin
    GameObject totalui;
    private Rigidbody rb;

    GameObject[] dices;

    private void Start()
    {
        totalui = GameObject.FindGameObjectWithTag("Dicetotal");
    }
    public void findDice()
    {
        dices = GameObject.FindGameObjectsWithTag("dice");
        totalui.GetComponent<stat>().dices = dices;
    }
    public void roll()
    {
        LaunchDice();
    }
    public void LaunchDice()
    {
        totalui.GetComponent<stat>().number = 0;
        foreach (var dice in dices) {
           
            if (dice != null) {
                launchForce = Random.Range(5f, 15f);
                torqueAmount = Random.Range(3f, 5f);
                rb = dice.GetComponent<Rigidbody>();
                // Reset velocity and angular velocity first
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;

                // Apply upward force
                rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);

                // Add random torque for spinning
                Vector3 randomTorque = new Vector3(
                    Random.Range(-torqueAmount, torqueAmount),
                    Random.Range(-torqueAmount, torqueAmount),
                    Random.Range(-torqueAmount, torqueAmount)
                );

                rb.AddTorque(randomTorque, ForceMode.Impulse);
            }


        }

    }
}
